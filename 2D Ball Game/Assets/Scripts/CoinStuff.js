#pragma strict

public var points : int = 5;

function OnTriggerEnter2D(other: Collider2D){
	Debug.Log("Triggered! " + points + "points");
	Destroy(gameObject);
}