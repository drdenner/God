using UnityEngine;
using System.Collections;

namespace God.player
{
	public class Keyboard : MonoBehaviour
	{
		public GameObject buildMenu;
	
		void Start ()
		{

		}
	
		void Update ()
		{
			// Build Menu
			if (Input.GetKeyDown (KeyCode.R)) { 
				buildMenu.SetActive (!buildMenu.activeSelf);
			}


		}
	}
}