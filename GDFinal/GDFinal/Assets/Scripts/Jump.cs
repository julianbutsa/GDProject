using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float JumpSpeed = 100.0f;
	public Vector3 moveDirection = Vector3.zero;


	public CharacterController controller;
	float jump = 1;
	float still = 0;

	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () {
		if (Input.GetKeyDown ("space")) {
			transform.Translate (Vector3.up * jump * Time.deltaTime);
		}
		if (transform.position.y < -10) {
			Application.LoadLevel(Application.loadedLevel);		
		}
	}
	

	void OnTriggerEnter(Collider t)
	{
		if (t.gameObject.name == "JumpPower") {
			jump = 5;
			Destroy (t.gameObject);
		}
	}
}
