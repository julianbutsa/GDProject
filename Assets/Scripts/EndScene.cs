using UnityEngine;
using System.Collections;

public class EndScene : MonoBehaviour {
	
	void OnTriggerEnter(){
		ScoreKeeper.room1++;
		Application.LoadLevel ("MainMenuScene");
		
	}
}