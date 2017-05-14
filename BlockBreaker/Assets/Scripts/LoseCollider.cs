using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D trigger)
	{
		levelManager.LoadLevel ("Lost");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
