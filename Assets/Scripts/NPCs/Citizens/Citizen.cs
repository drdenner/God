// Citizen Base Class
// getClosestBuilding() 

using UnityEngine;
using System.Collections;

namespace God.Npcs
{ 
	public class Citizen : MonoBehaviour
	{
		// Inspector
		public GameObject currentLocation;
		public GameObject home; 
		public GameObject work;

		// Other 
		NavMeshAgent navAgent;
		GameObject closestStorage;

		// Start
		void Start ()
		{
			navAgent = GetComponent<NavMeshAgent> ();

			currentLocation = home;

		}

		// Get Closest Building
		public GameObject getClosestBuilding (string name)
		{
			return getClosestGameObject ("Building", name);
		}

		public GameObject getClosestFoodToGather (string name)
		{
			return getClosestGameObject ("Food", name);
		}

		GameObject getClosestGameObject (string tag, string name)
		{            
			GameObject[] targets = GameObject.FindGameObjectsWithTag (tag);
			GameObject closest = null;
			float minDist = Mathf.Infinity;

			foreach (GameObject target in targets) {
				if (target.name == name) {
					float dist = Vector3.Distance (target.transform.position, transform.position);
					if (dist < minDist) {
						closest = target;
						minDist = dist;
					}
				}
			}
            
			return closest;
		}

		public void moveTo (GameObject target)
		{
			navAgent.SetDestination (target.transform.position);
		}

		public bool isMoving ()
		{
			if (!navAgent.pathPending) {
				if (navAgent.remainingDistance <= navAgent.stoppingDistance) {
					if (!navAgent.hasPath || navAgent.velocity.sqrMagnitude == 0f) {
						return false;
					}
				}
			}
			return true;
		}


		public void setLocation (GameObject currentLocation)
		{
			this.currentLocation = currentLocation;
		}

		public bool isDaytime ()
		{
			return true;
		}




	}
}