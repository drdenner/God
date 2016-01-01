using UnityEngine;
using System.Collections;

namespace God.Player.Builder
{
	public class Build : MonoBehaviour
	{

		RaycastHit hit;
		public int maxBuildDist = 20;
		Transform add;
		bool isBuilding = false;
		string prefabPath;
		string prefabName;

		void Start ()
		{
			add = GameObject.Find ("RetAdd").transform;
		}
	
		void Update ()
		{		
			if (isBuilding) {
				buildPrefab ();
			}


		}

		public void setPrefabPath (string type, string name)
		{
			prefabPath = type + "/" + name;
			prefabName = name;
			isBuilding = true;
		}


		void buildPrefab ()
		{
			if (Physics.Raycast (Camera.main.ScreenPointToRay (new Vector3 ((Screen.width / 2), (Screen.height / 2), 0)), out hit, maxBuildDist)) {
				add.GetComponent<Renderer> ().enabled = true;


				// Move Prefab around
				if (hit.transform.tag == "Building") {
					add.transform.position = hit.transform.position + hit.normal;
				}
				if (hit.transform.tag != "Building") {
					add.transform.position = new Vector3 (hit.point.x, hit.point.y + 0.5f, hit.point.z);
				}
				// Build Prefab
				if (Input.GetMouseButtonDown (0)) {
					GameObject building = (GameObject)Instantiate (Resources.Load (prefabPath), add.transform.position, Quaternion.identity);
					building.name = prefabName;

					isBuilding = false;
				} 
			} else {
				add.GetComponent<Renderer> ().enabled = false;
			}
		}


	}

	

}
