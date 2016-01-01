using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class Action : MonoBehaviour
	{			

		// Inspector Variables
		public GameObject prefab;
	

		// Other Variables
		string sourceTag;
		God.Managers.PoolObject PoolObject;




		public void doAction (Vector3 curserPosition)
		{			

			activateAction ();
		}
		
		void activateAction ()
		{
			GameObject obj = PoolObject.getObject ();
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
		

		
		
		
		public void setPooler (God.Managers.PoolObject pooler)
		{
			this.PoolObject = pooler;
		}
		
	}	
}


