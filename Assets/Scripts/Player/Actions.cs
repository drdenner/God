using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class Actions : MonoBehaviour
	{
		Action action;
	

		public void doAction (Vector3 curserPosition)
		{
			GameObject obj = GameObject.Find ("Object Pool");
			action = GetComponent<Action> ();
			
			foreach (Managers.PoolManager poolManager in obj.GetComponents<Managers.PoolManager>()) {
				
				if (action.prefab.name == poolManager.prefab.name) {
					action.setPooler (poolManager);
					action.doAction (curserPosition);
					break;
				}
			}
			
			
		}
		
		
	}
}