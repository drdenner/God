using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace God.Player.Builder
{
	public class MenuItem : MonoBehaviour
	{
		God.Player.Builder.Build build;

		public void Start ()
		{

			build = GameObject.Find ("Player").GetComponent<God.Player.Builder.Build> ();

		}

		public void buildPrefab ()
		{
			string name = gameObject.name;
			build.setPrefabPath ("Buildings", name);
		}


	}
}