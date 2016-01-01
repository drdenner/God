using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class test : MonoBehaviour
{

	public GameObject prefab;

	void Start ()
	{
		Texture2D preview = AssetPreview.GetMiniThumbnail (prefab); 
		Debug.Log (preview);
		RawImage image = GetComponent<RawImage> ();
		image.texture = preview;
	}
	

}
