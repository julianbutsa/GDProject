using UnityEngine;
using System.Collections;

public class EnemyMovement2 : MonoBehaviour {

	public float turnSpeed;
	void Update () {
		Vector3 direction = CheckDistance (100f);
		if (direction != Vector3.zero) {
			Quaternion wantedRoatation = Quaternion.LookRotation(direction);
			transform.rotation = Quaternion.Slerp(transform.localRotation, wantedRoatation, Time.deltaTime * turnSpeed);
		}
	}

	Vector3 CheckDistance(float max) {
		GameObject target = GameObject.FindGameObjectWithTag ("Player");
		
		if (target != null) {
			Vector3 origin = this.transform.position;
			origin.y += .8f;
			Vector3 delta = (target.transform.position - this.transform.position);
			Vector3 direction = delta;

			direction.y = 0;
			direction.Normalize();

			return direction;
		}
		return Vector3.zero;
	}
}
