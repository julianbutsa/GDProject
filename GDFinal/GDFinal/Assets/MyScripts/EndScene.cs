using UnityEngine;
using System.Collections;

public class EndScene : MonoBehaviour {

   void OnTriggerEnter(){
		if(Application.loadedLevelName == "4x4Puzzle"){
			Application.LoadLevel("5x5Puzzle");
		}		
		if(Application.loadedLevelName == "5x5Puzzle"){
			Application.LoadLevel("6x6Puzzle");
		}		
		if(Application.loadedLevelName == "6x6Puzzle"){
			Application.LoadLevel(0);
		}		
	}
}