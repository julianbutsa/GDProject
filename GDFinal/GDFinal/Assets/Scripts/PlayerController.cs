using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float pushPower = 2.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Switch") {
			LevelController.gameOver = true;
			return;
		}

		Rigidbody body = hit.collider.attachedRigidbody;
		if (body == null || body.isKinematic)
			return;
		// if too far below, the player may walk over it as defined
		if (hit.moveDirection.y < -.3f)
			return;

		Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);

		body.velocity = pushDir * pushPower;
	}
}
