// Pool Manager
// Creates an Objet Pool
// getPoolObject(name) returns a GameObject

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace God.Managers
{
	public class PoolManager : MonoBehaviour
	{
		Dictionary<string,PoolObject> pool = new Dictionary<string,PoolObject> ();

		void Start ()
		{
			createPoolList ();
		}

		void createPoolList ()
		{
			PoolObject[] poolObjects = GetComponents<PoolObject> ();
		
			foreach (PoolObject poolObject in poolObjects) {
				pool [poolObject.prefab.name] = poolObject;
			}	
		}

		public GameObject getPoolObject (string name)
		{
			GameObject poolObject = pool [name].getObject ();
			return poolObject;
		}
	}
}
