using UnityEngine;
using System.Collections;

public class InstructionButtons  {


	
	public void DisplayInstruct(){
		DisplayRules ();
		DisplayButtons ();
	}
	
	private void DisplayRules(){
		GUIStyle G = new GUIStyle ("label");
		G.fontSize = 16;
		G.normal.textColor = Color.white;
		G.fontStyle = FontStyle.BoldAndItalic;
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 -175, 600, 100), "Portal Puzzle:", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 -150, 600, 100), "- Use the Mouse Buttons to fire Portals.", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 -125, 600, 100), "- Reach the End Portal in the Allotted Time.", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 -100, 600, 100), "Sliding Box Puzzle:", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 -75, 600, 100), "- Push the Boxes in the Room into their respective holes.", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 -50, 600, 100), "Sliding Tile Puzzle:", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 -25, 600, 100), "- Click the tiles to move them into the correct organization", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2, 600, 100), "Platforming Puzzle:", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 +25, 600, 100), "- Jump from Platform to Platform to collect all the boxes, then reach the end.", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 +50, 600, 100), "Mirror Puzzle:", G);
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -200, Screen.height / 2 +75, 600, 100), "- Move the Mirrors so the light hits the goal.", G);

	}
	
	private void DisplayButtons(){
		if(GUI.Button (new Rect (Screen.width/2-75, Screen.height/2+100, 150,50), "Play Game")){
			Application.LoadLevel ("MainMenuScene");
		}
		if(GUI.Button (new Rect (Screen.width/2-75, Screen.height/2+150, 150,50), "Back")){
			MainMenu.currentMenu = MainMenu.MenuStates.MAINSCREEN;
		}
	}
	
}