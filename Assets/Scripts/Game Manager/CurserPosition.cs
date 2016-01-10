using UnityEngine;
using System.Collections;

namespace God.Helpers
{
	public class CurserPosition : MonoBehaviour
	{
		public static Vector3 curserPosition;
		void Update ()
		{

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		
			if (Physics.Raycast (ray, out hit, 500)) {
				curserPosition = hit.point;		
			}

		}
	}
}