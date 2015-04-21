using UnityEngine;
using System.Collections;

public class MainButtons  {
	
	public void DisplayMain(){
		DisplayTitle ();
		DisplayOptions ();
	}
	
	private void DisplayTitle(){
		GUIStyle G = new GUIStyle ("label");
		G.fontSize = 60;
		G.normal.textColor = Color.white;
		G.fontStyle = FontStyle.BoldAndItalic;
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -250, Screen.height / 2 -100, 600, 150), "Uplink", G);
		G.fontSize = 20;
		G.fontStyle = FontStyle.Bold;
		DrawOutline.DrawWithStyle (new Rect (Screen.width / 2 -250, Screen.height / 2 -35, 300, 300), "A Puzzle Platforming Game", G);
	}
	
	private void DisplayOptions(){
		if(GUI.Button (new Rect (Screen.width/2-75, Screen.height/2, 150,50), "Play Game")){
			Application.LoadLevel ("MainMenuScene");
		}
		if(GUI.Button (new Rect (Screen.width/2-75, Screen.height/2+50, 150,50), "Instructions")){
			MainMenu.currentMenu = MainMenu.MenuStates.INSTRUCTIONS;
		}
		if(GUI.Button (new Rect (Screen.width/2-75, Screen.height/2+100, 150,50), "Quit Game")){
			Application.Quit();
		}
	}
	
}