using UnityEngine;
using System.Collections;

public class Use : MonoBehaviour {
	//public bool playerIsNear();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider c){
		if(c.tag.Equals("Player")){

		}
	}

	void OnTriggerExit(){

	}
}
