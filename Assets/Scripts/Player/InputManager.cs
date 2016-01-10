using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class InputManager : MonoBehaviour
	{



	


		void Update ()
		{		

			if (Input.GetKeyDown (KeyCode.B)) { 
				gameObject.GetComponent<Player> ().playerState = Player.PlayerState.building;
			}
				





		}




	}
}