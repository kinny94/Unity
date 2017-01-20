using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	static Music instance = null;
	// Use this for initialization
	
	void Awake(){
		Debug.Log("Music Player Awake " + GetInstanceID());
	}
	
	void Start () {
		
		Debug.Log("Music Player Starts " + GetInstanceID() );
		if(instance != null){
			Destroy(gameObject);
			print ("Duplicate music player destroyed!!");
		}else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
