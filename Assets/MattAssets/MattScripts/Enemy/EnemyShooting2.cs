using UnityEngine;
using System.Collections;


public class EnemyShooting2 : MonoBehaviour {

	LineRenderer gunLine;
	public GameObject missile;
	public float timeToShoot;
	float chargeTime;
	void Start () {
		gunLine = GetComponent<LineRenderer> ();
		gunLine.material = new Material (Shader.Find("Particles/Additive"));
		chargeTime = 0f;
	}

	// Update is called once per frame
	void Update () {
		drawLine ();
	}

	void drawLine() {			
			Vector3 origin = this.transform.position;
		//origin.x -= .5f;
			origin.y += .6f;
		Vector3 direction = this.transform.forward;
			RaycastHit hit;
			gunLine.SetPosition (0, origin);

			if (Physics.Raycast (origin, direction, out hit, 100f)) {
				if (hit.collider.tag == "Player" && chargeTime >= timeToShoot) {
					Shoot ();
					chargeTime = 0;
				}
				else
					chargeTime += Time.deltaTime;
				gunLine.SetPosition (1, hit.point);
			} else
				gunLine.SetPosition (1, origin + direction * 100f);
	}

	void Shoot() {
		GameObject temp = (GameObject)GameObject.Instantiate (missile);
		temp.transform.position = this.transform.position;
		temp.transform.rotation = this.transform.rotation;
		//temp.transform.Rotate(new Vector3(90, 0, 0));
	}
}