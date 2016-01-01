using UnityEngine;
using System.Collections;

namespace God.Buildings
{
	public class Building : MonoBehaviour
	{
		// Inspector Variables
		public int health;
		public GameObject worker;

		// Other Variables
		bool created = false;
		God.Npcs.Citizen citizen;
		God.Managers.PoolManager poolManager;
		int food = 0;
		int maxFood = 50;

		void Update ()
		{
			if (!created) {
				create ();
			}
			
		}
		
		void create ()
		{
			poolManager = GameObject.Find ("Managers/Object Pool").GetComponent<God.Managers.PoolManager> ();
			spawn (worker.name);
			created = true;
		}
		
		
		void spawn (string name)
		{
			GameObject obj = poolManager.getPoolObject (name);
			citizen = obj.GetComponent<God.Npcs.Citizen> ();
			citizen.home = gameObject;

			Quaternion rot = transform.rotation;
			rot.x = 0;
			rot.z = 0;
			
			obj.transform.position = transform.position;
			obj.transform.rotation = rot;
			
			obj.SetActive (true);
		}

		// Trigger - On Enter
		void OnTriggerEnter (Collider other)
		{
			if (other.tag == "Citizen") {
				citizen = other.GetComponent<God.Npcs.Citizen> ();
				citizen.setLocation (gameObject);
			}
		}

		// Trigger - On Exit
		void OnTriggerExit (Collider other)
		{
			if (other.tag == "Citizen") {
				citizen = other.GetComponent<God.Npcs.Citizen> ();
				citizen.setLocation (null);
			}
		}

		public void addFood (int food)
		{
			this.food = this.food + food;
		}


	}
}