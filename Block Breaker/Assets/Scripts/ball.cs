using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public paddle pad; 
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - pad.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	if(!hasStarted){
			this.transform.position = pad.transform.position + paddleToBallVector;
			
			if(Input.GetMouseButtonDown(0)){
				//print ("Mouse Clciked!!");
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
	}
}
