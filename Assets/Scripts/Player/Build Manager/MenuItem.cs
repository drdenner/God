using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace God.Player
{
	public class MenuItem : MonoBehaviour
	{
		private God.Player.BuildManager buildManager;
		public GameObject player;
	

		public void Start ()
		{
			buildManager = GameObject.Find ("Player/Build Manager").GetComponent<God.Player.BuildManager> ();

		}

		public void buildPrefab ()
		{
			string name = gameObject.name;
			buildManager.startBuilding ("Buildings", name);
		
		}


	}
}