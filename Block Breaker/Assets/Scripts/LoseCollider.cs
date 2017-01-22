using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	public levelManager levemgr;
	
	void OnTriggerEnter2D(Collider2D trigger){
		print ("Trigger");
		levemgr.loadLevel("Win");
	}
	
	void onCollisionEnter2D(Collision2D collision){
		print("Collision ");
	}
}
