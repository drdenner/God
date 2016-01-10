using UnityEngine;
using System.Collections;

namespace God.Player
{
	public class CameraSettings : MonoBehaviour
	{
		public Camera topDownCamera;
		public Camera playerCamera;

		public void setCamara (string placement)
		{
			switch (placement) {
			case "top":
				{
					topDownCamera.GetComponent<Camera> ().enabled = true;
					playerCamera.GetComponent<Camera> ().enabled = false;
					break;
				}
			case "player":
				{
					topDownCamera.GetComponent<Camera> ().enabled = false;
					playerCamera.GetComponent<Camera> ().enabled = true;
					break;
				}		
			}
		}
	}
}