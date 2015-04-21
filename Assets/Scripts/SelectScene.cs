using UnityEngine;
using System.Collections;

public class SelectScene : MonoBehaviour {
	
	void OnTriggerEnter(){
		/*if (gameObject.name == "Door6(Clone)") {
			Application.LoadLevel("MainMenuScene");
			ScoreKeeper.level++;
				}*/
		if (ScoreKeeper.level == 1) {
			if (gameObject.name == "Door1") {
								Application.LoadLevel ("4x4Puzzle");
						}
			if (gameObject.name == "Door2") {
				LevelController.level = 1;
								Application.LoadLevel ("game");
						}
			if (gameObject.name == "Door3") {
								Application.LoadLevel ("PortalScene1");
						}
			if (gameObject.name == "Door4") {
								Application.LoadLevel ("Mirror_1");
						}
			if (gameObject.name == "Door5") {
								Application.LoadLevel ("Easy1.1");
			}
		}
		if (ScoreKeeper.level == 2) {
			if (gameObject.name == "Door1") {
				Application.LoadLevel ("5x5Puzzle");
			}
			if (gameObject.name == "Door2") {
				LevelController.level = 3;
				Application.LoadLevel ("game");
			}
			if (gameObject.name == "Door3") {
				Application.LoadLevel ("PortalScene2");
			}
			if (gameObject.name == "Door4") {
				Application.LoadLevel ("Mirror_2");
			}
			if (gameObject.name == "Door5") {
				Application.LoadLevel ("Medium1.1");
			}
		}
		if (ScoreKeeper.level == 3) {
			if (gameObject.name == "Door1") {
				Application.LoadLevel ("6x6Puzzle");
			}
			if (gameObject.name == "Door2") {
				LevelController.level = 2;
				Application.LoadLevel ("game");
			}
			if (gameObject.name == "Door3") {
				Application.LoadLevel ("PortalScene3");
			}
			if (gameObject.name == "Door4") {
				Application.LoadLevel ("Mirror_3");
			}
			if (gameObject.name == "Door5") {
				Application.LoadLevel ("Easy1.1");
			}
		}
	}
}
