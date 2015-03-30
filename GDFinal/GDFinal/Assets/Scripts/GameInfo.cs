using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour{

	public GameObject portalprefab1;
	public GameObject portalprefab2;
	public GameObject endPortalprefab;
	public GameObject player;
	public static GameObject Portal1;
	public static GameObject Portal2;

	// Use this for initialization
	void Start () {
		Invoke ("Enable", 1f);
		Portal1 = (GameObject) Instantiate (portalprefab1, new Vector3 (10, 1, 2), Quaternion.identity);
		Portal1.renderer.material.SetColor ("_Color", Color.red);
		Portal2 = (GameObject) Instantiate (portalprefab2, new Vector3 (-10, 1, 2), Quaternion.identity);
		Portal2.renderer.material.SetColor ("_Color", Color.blue);
		GameObject end  = (GameObject) Instantiate (endPortalprefab, new Vector3 (-30, 1, 0), Quaternion.identity);
		end.renderer.material.SetColor ("_Color", Color.yellow);
	}

	void Enable(){
		player.GetComponent<PlayerControllerPortal> ().enabled = true;
	}

	public static void setPortal(GameObject p, int n){
		if (n == 1) {
			Destroy (Portal1);
			Portal1 = p;
		} else {
			Destroy (Portal2);
			Portal2 = p;
		}
	}
	

}
