using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public LevelController controller;
	public GameObject closer;

	public float pressedTime = 2.0f;
	public float sinkVelocity = 1.0f;
	bool pressed;

	// Use this for initialization
	void Start () {
		pressed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (pressed == true && pressedTime > 0f) {
			transform.Translate (0, -Time.deltaTime * sinkVelocity, 0);
			pressedTime -= Time.deltaTime;
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Crate" && pressed == false) {
			Vector3 position = transform.position;
			Vector3 scale = transform.localScale;
			GameObject temp = (GameObject)GameObject.Instantiate(closer);
			temp.transform.position = new Vector3(position.x - scale.x, position.y + 3.85f, position.z);
			temp.transform.localScale = new Vector3(scale.x, .1f, scale.z);
			LevelController.pressesLeft -= 1;
			pressed = true;
		}
		if (collision.collider.tag == "Crate" && pressed == true && pressedTime <= 0f) {
			GameObject.Destroy(collision.collider.gameObject);
		}
	}
}
