using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	private static MusicPlayer musicPlayer;

	void Awake()
	{
		if (musicPlayer == null) {
			musicPlayer = this;
			GameObject.DontDestroyOnLoad (gameObject);
		} else
			Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
