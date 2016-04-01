using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {
	private GameObject selectedTile;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("test");
			Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
			foreach (Transform objectTransform in GetComponentInChildren<Transform>()) {
				GameObject gameObject = objectTransform.gameObject;
				Debug.Log(gameObject.GetComponent<BoxCollider2D>().bounds);
				if (gameObject.GetComponent<BoxCollider2D>().bounds.Contains((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition))) {
                    Debug.Log("test2");
                    selectedTile = gameObject;
				}
			}
		}

		if(selectedTile != null) {
			GameObject selection = GameObject.FindWithTag("Selection");
			selection.SetActive(true);
			selection.transform.position = selectedTile.transform.position;
		}
	}
}
