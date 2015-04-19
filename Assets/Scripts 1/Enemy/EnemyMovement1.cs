using UnityEngine;
using System.Collections;

public class EnemyMovement1 : MonoBehaviour {
	
	public float moveSpeed;
	public float turnSpeed;
	
	// Update is called once per frame
	void Update () {
		//GameObject target = GameObject.FindGameObjectWithTag ("Player");
		Vector3 direction = CheckDistance (12f);
		if (direction != Vector3.zero) {
			Debug.Log (transform.rotation);
			Quaternion wantedRoatation = Quaternion.LookRotation(direction);

			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			transform.rotation = Quaternion.Lerp(transform.rotation, wantedRoatation, Time.deltaTime * turnSpeed);
		}
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
