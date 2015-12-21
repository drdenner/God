// Handles Building of Prefabs

using UnityEngine;
using System.Collections;

namespace God.Player
{

	public class BuildManager : MonoBehaviour
	{


		void Start ()
		{
			object[] prefabs = loadPrefabs ("Buildings");


		}



		GameObject[] loadPrefabs (string prefabs)
		{
			return Resources.LoadAll<GameObject> (prefabs);
		}

		GameObject loadPrefab (string prefab)
		{
			return Resources.Load<GameObject> (prefab);
		}

		void build ()
		{
			Vector3 curser = God.Managers.CurserPosition.curserPosition;
			GameObject prefab = loadPrefab ("Buildings/House");
			Instantiate (prefab, curser, Quaternion.identity);
		}

	}	



}