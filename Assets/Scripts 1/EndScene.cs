using UnityEngine;
using System.Collections;

public class EndScene : MonoBehaviour {
	
	void OnTriggerEnter(){
		
		Application.LoadLevel ("MainMenuScene");
		
	}
}