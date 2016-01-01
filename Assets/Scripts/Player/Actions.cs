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
			
			foreach (Managers.PoolObject poolObject in obj.GetComponents<Managers.PoolObject>()) {
				
				if (action.prefab.name == poolObject.prefab.name) {
					action.setPooler (poolObject);
					action.doAction (curserPosition);
					break;
				}
			}
			
			
		}
		
		
	}
}