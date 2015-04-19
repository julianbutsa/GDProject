using UnityEngine;
using System.Collections;

public class A2 : MonoBehaviour {
	
	public GameObject B3;
	public Vector3 currentPosition = Vector3.zero;
	
	void Start () {
	}
	
	void Update () {
	}
	
	
	void OnTriggerEnter(Collider t)
	{
		currentPosition = new Vector3 (74,2,-82);
		if (t.gameObject.tag == "Player") {
			Instantiate (B3, currentPosition, Quaternion.Euler(0, 0, 0));
			Destroy (this.gameObject);
		}
		
	}
}