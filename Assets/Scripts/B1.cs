using UnityEngine;
using System.Collections;

public class B1 : MonoBehaviour {
	
	public GameObject B2;
	public Vector3 currentPosition = Vector3.zero;
	
	void Start () {
	}
	
	void Update () {
	}
	
	
	void OnTriggerEnter(Collider t)
	{
		currentPosition = new Vector3 (-16,0,0);
		if (t.gameObject.tag == "Player") {
			Instantiate (B2, currentPosition, Quaternion.Euler(0, 0, 0));
			Destroy (this.gameObject);
		}
		
	}
}
