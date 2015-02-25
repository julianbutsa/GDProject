using UnityEngine;
using System.Collections;

public class PlayerControllerPortal : MonoBehaviour {

	public GameObject projectile;
	public GameObject portalprefab1;
	public GameObject portalprefab2;

	private GameObject instance;


	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			if(instance != null){
				Destroy (instance);
			}
			instance = (GameObject) Instantiate(projectile, transform.position + transform.forward*.5f, transform.rotation);
			instance.renderer.material.SetColor ("_Color", Color.red);
			instance.rigidbody.AddForce(transform.forward * 200);

		}
		if (Input.GetMouseButtonUp (0)) {
			if(instance != null){
				GameObject p1 = (GameObject) Instantiate (portalprefab1, instance.transform.position, Quaternion.identity);
				//p1.renderer.material.SetColor ("_Color", Color.red);
				GameInfo.setPortal(p1, 1);
				Destroy(instance);
			}
		}
		if (Input.GetMouseButtonDown (1)) {
			if(instance != null){
				Destroy (instance);
			}
			instance = (GameObject) Instantiate(projectile, transform.position + transform.forward*.5f, transform.rotation);
			instance.renderer.material.SetColor ("_Color", Color.blue);
			instance.rigidbody.AddForce(transform.forward * 200);
			
		}
		if (Input.GetMouseButtonUp (1)) {
			if(instance != null){
				GameObject p2 = (GameObject) Instantiate (portalprefab2, instance.transform.position, Quaternion.identity);
				//p2.renderer.material.SetColor ("_Color", Color.blue);
				GameInfo.setPortal(p2, 2);
				Destroy(instance);
			}
		}

		if (transform.position.y <= 0) {
			transform.position = new Vector3(15, 1, 0);
		}

	}



	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Portal1") {
			transform.position = GameInfo.Portal2.transform.position;
			DestroyObject (GameInfo.Portal1);
			DestroyObject (GameInfo.Portal2);
		}
		if (other.gameObject.tag == "Portal2") {
			transform.position = GameInfo.Portal1.transform.position;
			DestroyObject (GameInfo.Portal1);
			DestroyObject (GameInfo.Portal2);
		}
		if (other.gameObject.tag == "EndPortal") {
			//end game
		}
	}



}