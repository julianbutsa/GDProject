using UnityEngine;
using System.Collections;

public class LevelDisplay : MonoBehaviour {

	private int level;

	void Update(){
		level = ScoreKeeper.level;
	}

	void OnGUI() {
		GUIStyle G = new GUIStyle ("label");
		G.fontSize = 25;
		G.normal.textColor = Color.white;
		G.fontStyle = FontStyle.BoldAndItalic;
		GUI.Label(new Rect(10, 5, 150, 100), "Level = ", G);
		GUI.Label(new Rect(100, 5, 150, 100), level.ToString (), G);

	}
}
