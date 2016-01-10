using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace God.Buildings
{
	public class Building : MonoBehaviour
	{
		// Inspector Variables
		public int health;
		public GameObject worker;


		// Private Variables
		private God.Npcs.Citizen citizen;
		private God.Managers.PoolManager poolManager;
		private int food = 0;
		private Dictionary<string, int> inventory = new Dictionary<string, int> ();

		public void create ()
		{
			poolManager = GameObject.Find ("Game Manager/Object Pool").GetComponent<God.Managers.PoolManager> ();
			spawn (worker.name);

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

		public void addItemToInventory (string name, int nr)
		{
			if (inventory .ContainsKey (name)) {
				inventory [name] = inventory [name] + nr;
			} else {
				inventory [name] = nr;
			}

		}
        
		public int removeItemFromInventory (string name, int nr)
		{
			if (inventory.ContainsKey (name)) {
				// check
				return inventory [name] = inventory [name] - nr;
			} else {
				return 0;
			}
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



        

	}
}