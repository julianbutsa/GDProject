using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public static int pressesLeft = 0;
	public static bool gameOver = false;
	bool finished = false;
	bool paused = false;

	public TextAsset levelData;
	public GameObject tile;
	public GameObject player;
	public GameObject box;
	public GameObject switchObject;
	public GameObject wall;
	public GameObject ceiling;

	public float tileSize = 10f;
	string[] textLines;

	int width = 0;
	int height = 0;

	float generateX;
	float generateZ;

	int startX;
	int startY;

	int buttonCount = 0;
	int crateCount = 0;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		gameOver = false;
		finished = false;
		paused = false;

		textLines = levelData.text.Split('\n');
		height = textLines.GetLength (0);

		for (int i = 0; i < height; ++i) {
			if (width < textLines[i].Length)
				width = textLines[i].Length;
		}

		if (width <= 0 || height <= 0) {
			Debug.LogError("Width and Height must be greater than zero");
			Application.Quit();
		}

		GameObject ceil = (GameObject)GameObject.Instantiate (ceiling);
		ceil.transform.localScale = new Vector3 (width * 10f, 1, height * 10f);

		generateZ = -height * tileSize / 2f;
		for (int i = 0; i < height; ++i) {
			generateX = -width * tileSize / 2f;
			for (int j = 0; j < textLines[i].Length; ++j) {
				if(textLines[i][j] == 'X' || textLines[i][j] == 'P' || textLines[i][j] == 'B') {
					GameObject temp = (GameObject)GameObject.Instantiate(tile);
					temp.transform.position = new Vector3(generateX, -2, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
				}
				if(textLines[i][j] == 'S') {
					GameObject temp = (GameObject)GameObject.Instantiate(switchObject);
					buttonCount++;
					temp.transform.position = new Vector3(generateX, -4, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
				}
				if(textLines[i][j] == 'P') {
					player.transform.position = new Vector3(generateX, 2, generateZ);
				}
				if(textLines[i][j] == 'B') {
					GameObject temp = (GameObject)GameObject.Instantiate(box);
					crateCount++;
					temp.transform.position = new Vector3(generateX, 2, generateZ);
				}
				if(textLines[i][j] == 'W') {
					GameObject temp = (GameObject)GameObject.Instantiate(wall);
					temp.transform.position = new Vector3(generateX, 6, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 20, tileSize);
				}
				generateX += tileSize;
			}
			generateZ += tileSize;
		}
		if (crateCount >= buttonCount)
			pressesLeft = buttonCount;
		else
			pressesLeft = crateCount;

	}

	void Update() {
		if (pressesLeft == 0)
			finished = true;
		if (!finished && !gameOver && !paused)
			Time.timeScale = 1f;
		else
			Time.timeScale = 0f;
	}

	void OnGUI() {
		if (!gameOver && !paused && !finished) {
			//Generate normal hud
			GUI.Label (
				new Rect (10, 10, Screen.width / 5, Screen.height / 6), 
				"SWITCHES LEFT: " + ((int)pressesLeft).ToString ());
		} else {
			string header;
			string command;
			
			//For determining what just happened that displays the screen
			if(gameOver)
				header = "GAME OVER";
			else if(finished)
				header = "LEVEL COMPLETE";
			else
				header = "PAUSED";
			
			//For when the level is beaten or not
			if(finished)
				command = "NEXT LEVEL";
			else
				command = "RESTART";
			
			GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), header);
			
			//restart the game on click
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+Screen.height/10+10, Screen.width/2-20, Screen.height/10), command)){
				if(!finished)
					//levelScript.resetGame();
				Application.LoadLevel(Application.loadedLevel);
				else
					Application.LoadLevel(0);
			}
			//exit the game
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+3*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "EXIT GAME")){
				Application.Quit();
			}
		}
	}
}
