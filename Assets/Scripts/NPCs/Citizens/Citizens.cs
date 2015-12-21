using UnityEngine;
using System.Collections;

namespace God.Npcs.Citizens
{
	public class Citizens : MonoBehaviour
	{

		public enum CitizenTypes
		{
			Idle,
			Builder,
			Farmer
	}
		;

		CitizenTypes citizenType; 


		void spawn ()
		{
			GameObject obj = GameObject.Find ("Object Pool");
						
			foreach (Managers.PoolManager poolManager in obj.GetComponents<Managers.PoolManager>()) {
					
				if (gameObject.name == poolManager.prefab.name) {
					//God.Player.Action.setPooler (poolManager);



					break;
				}
			}
				
				

		}


	}
}