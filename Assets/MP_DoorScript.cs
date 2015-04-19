using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class MP_DoorScript : MonoBehaviour{
	public bool open;
	Vector3 moveVector;
	// Use this for initialization
	void Start () {
		open = false;
		moveVector = new Vector3 (0.0f, -0.2f, 0.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (open) {
			if (gameObject.transform.position.y > 0){
				gameObject.transform.Translate(moveVector);
			
			}
			if(gameObject.transform.position.y < 0)
				Destroy (this.gameObject);
		}
	}

	public void openDoor(){
		this.open = true;
		Debug.Log ("unlocked door");
	}

	


}
