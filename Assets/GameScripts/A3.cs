using UnityEngine;
using System.Collections;

public class A3 : MonoBehaviour {
	
	public GameObject Goal1;
	public Vector3 currentPosition = Vector3.zero;
	
	void Start () {
	}
	
	void Update () {
	}
	
	
	void OnTriggerEnter(Collider t)
	{
		currentPosition = new Vector3 (70,2,92);
		if (t.gameObject.tag == "Player") {
			Instantiate (Goal1, currentPosition, Quaternion.Euler(0, 0, 0));
			Destroy (this.gameObject);
		}
		
	}
}
