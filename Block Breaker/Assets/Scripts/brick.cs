using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {

	public int maxHits = 1;
	private int timesHit;

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		timesHit++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
