using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c){
		if(c.tag.Equals("Player")){
			Application.LoadLevel (0);
		}
	}

}
