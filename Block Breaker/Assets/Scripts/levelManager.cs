using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {

	public void loadLevel(string name){
		Debug.Log("Level Load Requested: " + name);
		Application.LoadLevel(name);
	}
	
	public void quitRequest(string name){
		Debug.Log("Level quit request: " + name);
		Application.Quit();
	}
}
