using UnityEngine;
using System.Collections;

public class AppearP : MonoBehaviour {

	public GameObject AppearPlat;
	public Vector3 currentPosition = Vector3.zero;

	void Start () {
	}

	void Update () {
	}
	

	void OnTriggerEnter(Collider t)
	{
		currentPosition = new Vector3 (10,0,15);
		if (t.gameObject.name == "ShowPlat") {
			Instantiate (AppearPlat, currentPosition, Quaternion.Euler(0, 0, 0));
			Destroy (t.gameObject);
		}

	}
}
