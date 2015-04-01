using UnityEngine;
using System.Collections;

public class PlayerControllerPortal : MonoBehaviour {

	public GameObject projectile;
	public GameObject portalprefab1;
	public GameObject portalprefab2;
	public GameInfo2 gameinfo;

	private GameObject instance1;
	private GameObject instance2;


	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			if(instance1 != null){
				Destroy (instance1);
			}
			instance1 = (GameObject) Instantiate(projectile, transform.position + transform.forward*.5f, transform.rotation);
			instance1.renderer.material.SetColor ("_Color", Color.red);
			instance1.rigidbody.AddForce(transform.forward * 200);
			//Invoke ("makePortal1", 5f);

		}
		if (Input.GetMouseButtonUp (0)) {
			Invoke ("makePortal1", 0f);
		}
		if (Input.GetMouseButtonDown (1)) {
			if(instance2 != null){
				Destroy (instance2);
			}
			instance2 = (GameObject) Instantiate(projectile, transform.position + transform.forward*.5f, transform.rotation);
			instance2.renderer.material.SetColor ("_Color", Color.blue);
			instance2.rigidbody.AddForce(transform.forward * 200);
			//Invoke ("makePortal2", 5f);
			
		}
		if (Input.GetMouseButtonUp (1)) {
			Invoke ("makePortal2", 0f);
		}

		if (transform.position.y <= 0) {
			transform.position = new Vector3(15, 1, 0);
			gameinfo.timer = 240;
		}

	}

	public void reset(){
		Destroy (instance1);
		Destroy (instance2);
		GameObject thing = GameObject.FindGameObjectWithTag ("Portal1");
		Destroy (thing);
		thing = GameObject.FindGameObjectWithTag ("Portal2");
		Destroy (thing);
		transform.position = new Vector3(15, 1, 0);
	}

	void makePortal1(){
		if(instance1 != null){
			GameObject p1 = (GameObject) Instantiate (portalprefab1, instance1.transform.position, Quaternion.identity);
			//p1.renderer.material.SetColor ("_Color", Color.red);
			GameInfo.setPortal(p1, 1);
			Destroy(instance1);
		}
	}

	void makePortal2(){
		if(instance2 != null){
			GameObject p2 = (GameObject) Instantiate (portalprefab2, instance2.transform.position, Quaternion.identity);
			//p2.renderer.material.SetColor ("_Color", Color.blue);
			GameInfo.setPortal(p2, 2);
			Destroy(instance2);
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