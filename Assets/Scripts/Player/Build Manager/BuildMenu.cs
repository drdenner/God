using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class BuildMenu : MonoBehaviour
{
	public GameObject item;
	GameObject[] prefabs;

	void Start ()
	{
		RectTransform containerRect = gameObject.GetComponent<RectTransform> ();
		RectTransform itemRect = item.GetComponent<RectTransform> ();

		float itemHeight = containerRect.rect.height;
		float ratio = itemHeight / itemRect.rect.height;
		float itemWidth = itemRect.rect.width * ratio;

		prefabs = loadPrefabs ("Buildings");

		float x = 0;

		for (int i = 0; i< prefabs.Length; i++) {
			GameObject newItem = Instantiate (item) as GameObject;
			RectTransform newItemRect = newItem.GetComponent<RectTransform> ();

			newItemRect.offsetMin = new Vector2 (x, 0);
			x = x + itemWidth;
			newItemRect.offsetMax = new Vector2 (x, itemHeight);

			// Set Name
			Text itemName = newItem.transform.FindChild ("Name").GetComponent<Text> ();
			itemName.text = prefabs [i].name;
			newItem.name = prefabs [i].name;

			// Set Thumbnail

			Image image = newItem.transform.FindChild ("Thumbnail").GetComponent<Image> ();

			Texture2D preview = AssetPreview.GetMiniThumbnail (prefabs [i]); 

			Rect rect = new Rect (0, 0, 64, 64);
			image.sprite = Sprite.Create (preview, rect, new Vector2 (0f, 0f), 125);

			newItem.transform.SetParent (transform, false);
		}
		gameObject.SetActive (false);

	}

	GameObject[] loadPrefabs (string prefabs)
	{
		return Resources.LoadAll<GameObject> (prefabs);
	}
}
