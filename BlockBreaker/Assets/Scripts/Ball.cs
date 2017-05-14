using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Platform platform;

	private bool gameStarted = false;
	private Vector3 platformToBallVector;

	// Use this for initialization
	void Start () {
		platformToBallVector = this.transform.position - platform.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameStarted) {
			this.transform.position = platform.transform.position + platformToBallVector;

			if (Input.GetMouseButtonDown (0)) {
					gameStarted = true;
				this.rigidbody2D.velocity = new Vector2 (2f, 10f); 
			}
		}
	}
}
