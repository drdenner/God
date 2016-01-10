using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class BuildManager : MonoBehaviour
	{
		public float rotateMod = 45.0f;
		public GameObject setPrefab;
		public GameObject buildMenu;
		private bool isFire1InUse = false;
		private bool isFire2InUse = false;
		public bool isBuilding = false;
		public bool isPlaced = false;
		private GameObject prefab = null;
		private string tag;
		private Color color;
		private Renderer rend;
		string prefabPath;


		// Mono - Update
		void Update ()
		{

			// Building
			if (isBuilding) {
				// Build
				if (Input.GetAxisRaw ("Fire1") != 0) {
					if (isFire1InUse == false) {
						buildPrefab ();
						isFire1InUse = true;
					}
				} else if (Input.GetAxisRaw ("Fire1") == 0) {
					isFire1InUse = false;
				}    

				// Place
				if (!isPlaced) {
					placePrefab ();
				}

				// Rotate
				if (Input.GetAxis ("Mouse ScrollWheel") == 0.1f) {
					rotatePrefab (rotateMod);
				} else if (Input.GetAxis ("Mouse ScrollWheel") == -0.1f) {
					rotatePrefab (-rotateMod);
				} 
			}

		}

		public void showMenu ()
		{
			buildMenu.SetActive (!buildMenu.activeSelf);
		}


		// Start Building
		public void startBuilding (string type, string name)
		{
			prefabPath = type + "/" + name;
			isBuilding = true;
			isPlaced = false;
			//prefab = (GameObject)Instantiate (setPrefab, Vector3.zero, setPrefab.transform.rotation);
			prefab = (GameObject)Instantiate (Resources.Load (prefabPath), Vector3.zero, setPrefab.transform.rotation);
			prefab.name = setPrefab.name;
			tag = prefab.tag;
			prefab.tag = "Untagged";
			prefab.layer = 2;
			rend = prefab.GetComponent<Renderer> ();
			color = rend.material.color;
			rend.material.color = Color.black;

		}

		// Build Prefab
		void buildPrefab ()
		{
			prefab.tag = tag;
			prefab.layer = 0;
			isPlaced = true;
			isBuilding = false;
			rend.material.color = color;
			prefab.GetComponent<God.Buildings.Building> ().create ();
		}

		// Place Prefab
		void placePrefab ()
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "Terrain" || hit.transform.tag == "Untagged") {
					prefab.transform.position = new Vector3 (hit.point.x, 0, hit.point.z);
				} else {
					if (hit.normal != new Vector3 (0, 1, 0)) {
						prefab.transform.position = hit.transform.position + hit.normal * 5; 
					} 
				}
			}
		}


		// Rotate Prefab
		void rotatePrefab (float rotateMod)
		{
			prefab.transform.Rotate (0, rotateMod, 0);
		}
	}
}