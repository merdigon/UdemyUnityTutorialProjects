using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public float xMousePosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		xMousePosition = Input.mousePosition.x / Screen.width * 16;

		xMousePosition = Mathf.Clamp (xMousePosition, 0.5f, 15.5f);

		this.transform.position = new Vector3 (xMousePosition, this.transform.position.y, 0f);
	}
}
