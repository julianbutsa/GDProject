using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public enum MenuStates{
		MAINSCREEN, 
		INSTRUCTIONS	
	}
	
	public static MenuStates currentMenu = new MenuStates();
	private MainButtons main = new MainButtons();
	private InstructionButtons instruct = new InstructionButtons();
	
	void Start(){
		currentMenu = MenuStates.MAINSCREEN;
	}
	
	void Update(){
		switch (currentMenu) {
		case(MenuStates.MAINSCREEN):
			break;
		case(MenuStates.INSTRUCTIONS):
			break;
			
		}
		
		
	}
	
	void OnGUI(){
		if (currentMenu == MenuStates.MAINSCREEN) {
			main.DisplayMain();
			//Display Classes
		}
		if (currentMenu == MenuStates.INSTRUCTIONS) {
			instruct.DisplayInstruct();
			//Display Classes
		}
	}
	
}