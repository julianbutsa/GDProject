using UnityEngine;
using System.Collections;

public class CloserController : MonoBehaviour {

	public float startingTime = 1.0f;
	float timeLeft;

	// Use this for initialization
	void Start () {
		timeLeft = startingTime;
	}
	
	// Update is called once per frame
	//Shift right until end
	void Update () {
		if (timeLeft > 0.0f) {
			transform.Translate(Time.deltaTime / startingTime * transform.localScale.x, 0, 0);
			timeLeft -= Time.deltaTime;
		}
	}
}
