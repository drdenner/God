using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class Action : MonoBehaviour
	{			

		// Inspector Variables
		public GameObject prefab;
		public int level = 1;
		public float projectileSpeed = 10f;
		public float projectileSpeedMod = 0f;
		public float damage = 50f;
		public float damageMod = 0f;
		public float range = 10f;
		public float rangeMod = 0f;
		public bool piercing = false;
		public float attackSpeed;	
				
		// Other Variables
		string sourceTag;
		God.Managers.PoolManager poolManager;




		public void doAction (Vector3 curserPosition)
		{			

			activateAction ();
		}
		
		void activateAction ()
		{
			GameObject obj = poolManager.getObject ();
			if (obj == null) {
				return;
			}

			
			
			Quaternion rot = transform.rotation;
			rot.x = 0;
			rot.z = 0;
			
			obj.transform.position = transform.position;
			obj.transform.rotation = rot;
			
			obj.SetActive (true);
		}
		

		
		
		
		public void setPooler (God.Managers.PoolManager pooler)
		{
			this.poolManager = pooler;
		}
		
	}	
}


