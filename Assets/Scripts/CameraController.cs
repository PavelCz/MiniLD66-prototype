using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Camera camera;
	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera>();
	
	}
	
	// Update is called once per frame
	void Update () {
		int horizontal = 0;
		int vertical = 0;

		horizontal = (int)(Input.GetAxisRaw("Horizontal"));
		
		vertical = (int)(Input.GetAxisRaw("Vertical"));

		transform.position += new Vector3(horizontal, vertical, 0);
	}
}
