using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameInfo2 : MonoBehaviour {

	public GameObject player;
	public GameObject endPortalprefab;
	private PlayerControllerPortal pscript;
	public float timer;
	public Text time;

	// Use this for initialization
	void Start () {
		pscript = player.GetComponent<PlayerControllerPortal> ();
		Invoke ("Enable", 1f);
		GameObject end  = (GameObject) Instantiate (endPortalprefab, new Vector3 (12, 81, 0), Quaternion.identity);
		end.renderer.material.SetColor ("_Color", Color.yellow);
		timer = 240;
	}

	void Enable(){
		player.GetComponent<PlayerControllerPortal> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			pscript.reset();
			timer = 240;

		}
		time.text = timer.ToString ();
	}


}
