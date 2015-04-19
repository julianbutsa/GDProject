using UnityEngine;
using System.Collections;

public class AppearGoal : MonoBehaviour {
	
	public GameObject Goal;
	public Vector3 currentPosition = Vector3.zero;
	
	void Start () {
	}
	
	void Update () {
	}
	
	
	void OnTriggerEnter(Collider t)
	{
		currentPosition = new Vector3 (-14,11,66);
		if (t.gameObject.tag == "Player") {
			Instantiate (Goal, currentPosition, Quaternion.Euler(0, 0, 0));
			Destroy (this.gameObject);
		}
		
	}
}
