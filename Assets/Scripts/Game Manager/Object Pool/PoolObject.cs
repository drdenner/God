// Pool Object

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace God.Managers
{
	public class PoolObject : MonoBehaviour
	{
		// Inspector Variables
		public GameObject prefab;
		public int maxAmount = 5;
		public bool noMax = true;
	
		// Other Variables
		List<GameObject> poolList;
		private GameObject container;
		private GameObject par;
	
		void Start ()
		{
			container = GameObject.Find ("Object Pool");
			par = new GameObject (prefab.name);
			par.transform.parent = container.transform;
			init ();
		}
	
		void init ()
		{
		
		
			poolList = new List<GameObject> ();
		
			for (int i = 0; i< maxAmount; i++) {
				GameObject obj = (GameObject)Instantiate (prefab);
				obj.transform.parent = par.transform;
				obj.name = prefab.name;
				obj.SetActive (false);
				poolList.Add (obj);
			
			
			}
		
		}
	
		public GameObject getObject ()
		{
			for (int i = 0; i < poolList.Count; i++) {
				if (poolList [i].activeInHierarchy == false) {
					poolList [i].SetActive (true);
					return poolList [i];
				
				}
			}
		
			if (noMax) {
				GameObject obj = (GameObject)Instantiate (prefab);
				obj.transform.parent = par.transform;
				poolList.Add (obj);
				return obj;
			} 
		
		
			return null;
		}
	
	}
	
	
	
	
	
	
}
