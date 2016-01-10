using UnityEngine;
using System.Collections;

namespace God.Managers
{
	public class PoolMember : MonoBehaviour
	{
		public float timeToDie;
	
		void OnEnable ()
		{
			if (timeToDie == 0) {
			
			} else {
				Invoke ("destroy", timeToDie);
			}
		
		}
	
		void destroy ()
		{
			gameObject.SetActive (false);
		}
	
		void OnDisable ()
		{
			CancelInvoke ();
		}
	
	}
}