using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour
{
    
	bool isPlaced;
	Vector3 mousePosition;
	private bool isAxisInUse = false;

	void update ()
	{
		if (!isPlaced) {
			mousePosition = God.Helpers.CurserPosition.curserPosition;
			relocatePrefab ();
		}

		if (Input.GetAxisRaw ("Fire1") != 0) {
			if (isAxisInUse == false) {
				placePrefab ();
				isAxisInUse = true;
			}
		}
		if (Input.GetAxisRaw ("Fire1") == 0) {
			isAxisInUse = false;
		}    
	}

	void relocatePrefab ()
	{
//		transform.position = new Vector3 (mousePosition);
	}

	void placePrefab ()
	{

	}

}
