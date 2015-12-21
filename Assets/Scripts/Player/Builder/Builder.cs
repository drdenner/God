using UnityEngine;
using System.Collections;

public class Builder : MonoBehaviour
{
	RaycastHit hit;
	int maxBuildDist = 10;
	Transform add;
	bool isBuilding = false;

	void Start ()
	{
		add = GameObject.Find ("RetAdd").transform;
	}
	
	void Update ()
	{		
		if (Input.GetKeyDown (KeyCode.E)) {
			isBuilding = true;
		}

		if (isBuilding) {
			buildPrefab ();
		}


	}

	void buildPrefab ()
	{
		if (Physics.Raycast (Camera.main.ScreenPointToRay (new Vector3 ((Screen.width / 2), (Screen.height / 2), 0)), out hit, maxBuildDist)) {
			add.GetComponent<Renderer> ().enabled = true;
			if (hit.transform.tag == "Block") {
				add.transform.position = hit.transform.position + hit.normal;
			}
			if (hit.transform.tag != "Block") {
				add.transform.position = new Vector3 (hit.point.x, hit.point.y + 0.5f, hit.point.z);
			}
			if (Input.GetMouseButtonDown (0)) {
				GameObject block = (GameObject)Instantiate (Resources.Load ("Buildings/Block"), add.transform.position, Quaternion.identity);
				isBuilding = false;
			} 
		} else {
			add.GetComponent<Renderer> ().enabled = false;
		}
	}




	

}
