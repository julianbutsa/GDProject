using UnityEngine;
using System.Collections;

public class MissileScript : MonoBehaviour {

	public float maxTime = 10f;
	public float speed = 12.0f;
	float time;

	void Start() {
		time = 0f;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		time += Time.deltaTime;
		if (time >= maxTime)
			Destroy (this.gameObject);
	}
}
