using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void LoadLevel(string name)
	{
		if (name.Equals ("quit"))
			Application.Quit ();
		else
			Application.LoadLevel (name);
	}
}
