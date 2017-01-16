using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	int maxGuesses = 10;
	
	public Text text;
	
	// Use this for initialization
	void Start () {
		startGame();
	}
	
	void startGame(){
		
		max =  1000;
		min = 1;
		nextGuess();
	}	
	
	void nextGuess(){
		
		guess = Random.Range(min, max+1);
		text.text = "Is your number is : " + guess.ToString();
		maxGuesses = maxGuesses - 1;
		
		if(maxGuesses <= 0){
			Application.LoadLevel("Win");
		}
		
	}
	
	public void guessHigher(){
		min = guess;
		nextGuess();
	}
	
	public void guessLower(){
		max = guess;
		nextGuess();
	}
		
	
}
