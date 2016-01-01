using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class Movement : MonoBehaviour
	{
		public float mouseSensitivity = 2.0f;
		public float speed = 5.0f;

		void Update ()
		{
			rotation ();
			move ();
		}

		void rotation ()
		{
			float mouseX = Input.GetAxis ("Mouse X");
			transform.Rotate (0, mouseX * mouseSensitivity, 0);
			float mouseY = Input.GetAxis ("Mouse Y");
			Camera.main.transform.Rotate (-mouseY * mouseSensitivity, 0, 0);
		}

		void move ()
		{
			// WASD
			float translation = Input.GetAxis ("Vertical") * speed;
			transform.Translate (Vector3.forward * translation * Time.deltaTime);
			float rotation = Input.GetAxis ("Horizontal") * speed;
			transform.Translate (Vector3.right * rotation * Time.deltaTime);
		}
	}
}