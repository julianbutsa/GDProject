using UnityEngine;
using System.Collections;

public class DrawOutline {
	
	public static void DrawWithOutline(Rect r, string text){
		GUIStyle outline = new GUIStyle();
		Rect a = r;
		outline.normal.textColor = Color.black;
		outline.wordWrap = true;
		GUI.Label (a, text, outline);
		a.x--;
		GUI.Label (a, text, outline);
		a.x++;
		a.y--;
		GUI.Label (a, text, outline);
		a.y++;
		a.x++;
		GUI.Label (a, text, outline);
		a.x--;
		a.y++;
		GUI.Label (a, text, outline);
		a.y--;
		outline.normal.textColor = Color.white;
		GUI.Label (r, text, outline);
	}
	
	public static void DrawWithStyle(Rect r, string text, GUIStyle s){
		GUIStyle outline = s;
		Rect a = r;
		outline.normal.textColor = Color.black;
		outline.wordWrap = true;
		GUI.Label (a, text, outline);
		a.x--;
		GUI.Label (a, text, outline);
		a.x++;
		a.y--;
		GUI.Label (a, text, outline);
		a.y++;
		a.x++;
		GUI.Label (a, text, outline);
		a.x--;
		a.y++;
		GUI.Label (a, text, outline);
		a.y--;
		outline.normal.textColor = Color.white;
		GUI.Label (r, text, outline);
	}
}
