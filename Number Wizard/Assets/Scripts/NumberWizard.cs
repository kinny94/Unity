using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start () {
		startGame();
	}
	
	void startGame(){
		
		max =  1000;
		min = 1;
		guess = 500;
		
		max = max + 1;
			
		print("***********************************");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head!!");
		
		print ("the highes number you can pick is : " + max);
		print("The lowest number you can pick is : " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print("Up = Higher, Down = Lower, Enter = Equal");
		
	}	
	
	void nextGuess(){
		
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print("Up = Higher, Down = Lower, Enter = Equal");
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Up Key was pressed!!");
			min = guess;
			nextGuess();
		}
		
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down Key was pressed!!");
			max = guess;
			nextGuess();
		}
		
		else if(Input.GetKeyDown(KeyCode.Return)){
			print("I won!");
			startGame();
			
		}
	}
}
