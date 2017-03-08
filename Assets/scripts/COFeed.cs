using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class COFeed : MonoBehaviour
{

		public GameObject							content;
		public GameObject							livefeedItemPrefab;
		public float                               livefeedItemHeight;
		public Texture2D[]							photos;
		public Image   								feedtemplate;
		public int									numItems;

		// Use this for initialization
		void Start ()
		{
	

		}
	
		// Update is called once per frame
		void Update ()
		{
	


		}

		void OnEnable ()
		{
				StartCoroutine ("CreateItems");
		}

		IEnumerator CreateItems ()
		{
				Debug.Log ("CreateItems");
				//Debug.Log (feedtemplate.rectTransform.localScale);
				feedtemplate.rectTransform.localScale = new Vector3 (3f, livefeedItemHeight * numItems, 3f);

				for (int i=0; i<numItems; i++) {
						AddFeedItem (i);
				}

				yield return null;
		}

		private void AddFeedItem (int index)
		{
				Debug.Log ("AddFeedItem");
				GameObject tempFeedItem = Instantiate (livefeedItemPrefab) as GameObject;
				tempFeedItem.name = "feeditem " + index;
				//setting parent.

				tempFeedItem.transform.parent = content.transform;
				tempFeedItem.transform.localPosition = new Vector3 (0.0f, livefeedItemHeight * index, 0.0f);
				tempFeedItem.transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);

				//COLivefeedItem livefeedScript = tempFeedItem.GetComponent<COLivefeedItem>();

				//Debug.Log("AddFeedItem script");

				GameObject newsimageObject = tempFeedItem.transform.FindChild ("newsimage").gameObject;

				Image newsImage = newsimageObject.GetComponent<Image> ();

				Texture2D tempTex = photos [index % 10];
				Sprite tempSprite = Sprite.Create (tempTex, new Rect (0.0f, 0.0f, tempTex.width, tempTex.height), new Vector2 (0.5f, 0.5f));

				newsImage.sprite = tempSprite;

				GameObject statusTextGO = tempFeedItem.transform.FindChild ("newstext").gameObject;
				Text statusTextLabel = statusTextGO.GetComponent<Text> ();
				statusTextLabel.text = "dummytext" + index;

		}
	
}
