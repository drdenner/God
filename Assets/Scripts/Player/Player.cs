using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class Player : MonoBehaviour
	{

		// Other Variables

		Vector3 curserPosition;
	
		Actions actions;



		void Start ()
		{
		
			actions = GetComponent<Actions> ();
		
		}
		


		
		// Update
		private void Update ()
		{
			controller ();
			
			
		}
		
		// Controller
		private void controller ()
		{
			if (Input.GetMouseButton (0)) {
				//ClickToMove.Move (navAgent, getCurserPosition ());
			} 
			if (Input.GetMouseButtonDown (1) || Input.GetKey (KeyCode.Q)) {
				actions.doAction (getCurserPosition ());
				
			}
		}
		

		

		

		
		Vector3 getCurserPosition ()
		{
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit, 500)) {
				curserPosition = hit.point;		
			}
			return curserPosition;
		}
	}
}
