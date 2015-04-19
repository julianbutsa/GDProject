using UnityEngine;
using System.Collections;

public class PlatAppear : MonoBehaviour {
	
	public GameObject PlatTwo;
	public Vector3 currentPosition = Vector3.zero;
	
	void Start () {
	}
	
	void Update () {
	}
	
	
	void OnTriggerEnter(Collider t)
	{
		currentPosition = new Vector3 (4,9,62);
		if (t.gameObject.tag == "Player") {
			Instantiate (PlatTwo, currentPosition, Quaternion.Euler(0, 0, 0));
			Destroy (this.gameObject);
		}
		
	}
}