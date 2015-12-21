using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class Movement : MonoBehaviour
	{

		public float speed = 5.0f;
		public float mouseSensitivity = 2.0f;


		void Update ()
		{
			float mouseX = Input.GetAxis ("Mouse X");
			transform.Rotate (0, mouseX, 0);
			float mouseY = Input.GetAxis ("Mouse Y");
			Camera.main.transform.Rotate (-mouseY, 0, 0);

			if (Input.GetKey (KeyCode.W)) {

				transform.Translate (Vector3.forward * speed * Time.deltaTime);
			}
		}



	}
}