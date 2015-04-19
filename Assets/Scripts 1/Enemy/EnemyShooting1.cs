using UnityEngine;
using System.Collections;


public class EnemyShooting1 : MonoBehaviour {

	LineRenderer gunLine;
	Light gunLight;
	ParticleSystem gunParticles;
	public float timeToShoot;
	public float shootTime;
	float chargeTime;
	void Start () {
		gunLine = GetComponent<LineRenderer> ();
		gunLight = GetComponent<Light> ();
		gunParticles = GetComponent<ParticleSystem> ();
		gunLine.material = new Material (Shader.Find("Particles/Additive"));
		chargeTime = 0f;
	}

	// Update is called once per frame
	void Update () {
		drawLine ();
	}

	void drawLine() {
		if (chargeTime < timeToShoot) {					
			Vector3 origin = this.transform.position;
			Vector3 direction = this.transform.forward;
			RaycastHit hit;
			gunLine.SetPosition (0, origin);

			if (Physics.Raycast (origin, direction, out hit, 100f)) {
				if (hit.collider.tag == "Player")
					chargeTime += Time.deltaTime;
				else
					chargeTime = 0;
				gunLine.SetPosition (1, hit.point);
			} else
				gunLine.SetPosition (1, origin + direction * 100f);

			if (chargeTime >= timeToShoot)
				Shoot ();

		} else {
			chargeTime += Time.deltaTime;
			if(chargeTime >= shootTime) {
				chargeTime = 0f;
				StopShooting();
			}
		}
	}

	void Shoot() {
		gunLine.SetColors (Color.yellow, Color.yellow);
		gunLight.enabled = true;
		gunParticles.Stop ();
		gunParticles.Play ();
		PauseButtonController.gameOver = true;
	}
	void StopShooting() {
		gunLine.SetColors (Color.red, Color.red);
		gunLight.enabled = false;
		gunParticles.Stop ();
	}
}