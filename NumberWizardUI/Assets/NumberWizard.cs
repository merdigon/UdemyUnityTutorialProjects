using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxGuessedAllowed = 10;
	int guessCount;

	public Text guessLabel;

	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guessCount = 0;
		NextGuess ();
	}

	public void UpArrowKey_Pressed()
	{
		min = guess;
		NextGuess();
	}

	public void DownArrowKey_Pressed()
	{
		max = guess;
		NextGuess();
	}

	public void EqualKey_Pressed()
	{
		Application.LoadLevel ("Lost");
	}
	
	void NextGuess () {
		guess = Random.Range (min, max+1);
		guessCount++;
		if (guessCount >= maxGuessedAllowed)
			Application.LoadLevel ("Won");
		else
			guessLabel.text = guess.ToString();
	}
}
