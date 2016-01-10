using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class Player : MonoBehaviour
	{
		public enum PlayerState
		{
			idle,
			building
		}

		public PlayerState playerState;

		private God.Player.BuildManager buildManager;

		void Start ()
		{
			buildManager = GameObject.Find ("Player/Build Manager").GetComponent<God.Player.BuildManager> ();
			playerState = PlayerState.idle;
		}

		void Update ()
		{
			if (playerState == PlayerState.building) {
				if (buildManager.buildMenu.activeSelf == false) {
					gameObject.GetComponent<God.Player.CameraSettings> ().setCamara ("top");
					buildManager.showMenu ();
				}

			}
		}

       
	}
}
