using UnityEngine;
using System.Collections;

public class A1 : MonoBehaviour {
	
	public GameObject B2;
	public Vector3 currentPosition = Vector3.zero;
	
	void Start () {
	}
	
	void Update () {
	}
	
	
	void OnTriggerEnter(Collider t)
	{
		currentPosition = new Vector3 (-62,2,96);
		if (t.gameObject.tag == "Player") {
			Instantiate (B2, currentPosition, Quaternion.Euler(0, 0, 0));
			Destroy (this.gameObject);
		}
		
	}
}
