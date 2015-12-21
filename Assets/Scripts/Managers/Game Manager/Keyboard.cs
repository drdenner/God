using UnityEngine;
using System.Collections;

public class Keyboard : MonoBehaviour
{

	public GameObject buildMenu;

	void Start ()
	{
		buildMenu.SetActive (false);
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R)) { // Build Menu
			buildMenu.SetActive (!buildMenu.activeSelf);
		}
	}
}
