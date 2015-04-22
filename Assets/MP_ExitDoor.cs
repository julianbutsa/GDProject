using UnityEngine;
using System.Collections;

public class MP_ExitDoor : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider c){
		Application.LoadLevel ("MainMenuScene");
	}
}
