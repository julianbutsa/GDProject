using UnityEngine;
using System.Collections;

public class EnemyMovement3 : MonoBehaviour {

	Animator anim;
	public float moveSpeed;
	public float turnSpeed;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 direction = CheckDistance (2f);
		if (direction != Vector3.zero) {
			anim.SetTrigger ("Stop");
			return;
		}

		direction = CheckDistance (6f);
		if (direction != Vector3.zero) {
			anim.SetTrigger("Walk");
			Quaternion wantedRoatation = Quaternion.LookRotation(direction);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			transform.rotation = Quaternion.Lerp(transform.rotation, wantedRoatation, Time.deltaTime * turnSpeed);
			return;
		}
		anim.SetTrigger ("Stop");
	}

	Vector3 CheckDistance(float max) {
		GameObject target = GameObject.FindGameObjectWithTag ("Player");
		
		if (target != null) {
			Vector3 origin = this.transform.position;
			Vector3 delta = (target.transform.position - this.transform.position);
			Vector3 direction = delta;

			direction.y = 0;
			direction.Normalize();

			RaycastHit hit;
			if(Physics.Raycast(origin, direction, out hit, max)) {
				if(hit.collider.tag == "Player")
					return direction;
			}
		}
		return Vector3.zero;
	}
}
