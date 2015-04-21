using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelController : MonoBehaviour {
	public static int level = 1;
	public static int pressesLeft = 0;
	public static bool gameOver = false;

	public char[] tileCodes;
	public GameObject[] tiles;

	public TextAsset[] levelData;
	public AudioSource[] music;
	public GameObject tile;
	public GameObject player;
	public GameObject box;
	public GameObject switchObject;
	public GameObject wall;
	public GameObject ceiling;
	public GameObject ramp;

	public GameObject cover;
	public GameObject spider;
	public GameObject turret;
	public GameObject kyle;
	public GameObject magma;

	public Text pressesLeftText;

	public float tileSize = 10f;
	string[] textLines;

	int width = 0;
	int height = 0;

	float generateX;
	float generateY;
	float generateZ;

	int startX;
	int startY;

	int buttonCount = 0;
	int crateCount = 0;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		gameOver = false;

		TextAsset currentLevel = levelData [level - 1];
		AudioSource source = music [level - 1];
		source.Play ();
		textLines = currentLevel.text.Split('\n');
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

		generateY = 0;
		generateZ = -height * tileSize / 2f;
		for (int i = 0; i < height; ++i) {
			if(textLines[i].Length == 0) {
				generateZ = -height * tileSize / 2f;
				generateY += 4;
				continue;
			}
			generateX = -width * tileSize / 2f;
			for (int j = 0; j < textLines[i].Length; ++j) {
				if(textLines[i][j] == 'X' || textLines[i][j] == 'P' || textLines[i][j] == 'B' || textLines[i][j] == 'A'
				   || textLines[i][j] == 'T' || textLines[i][j] == 'K') {
					GameObject temp = (GameObject)GameObject.Instantiate(tile);
					temp.transform.position = new Vector3(generateX, -2 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
				}
				if(textLines[i][j] == 'M' || textLines[i][j] == 'I') {
					GameObject temp = (GameObject)GameObject.Instantiate(magma);
					temp.transform.position = new Vector3(generateX, -2 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
				}
				if(textLines[i][j] == 'S') {
					GameObject temp = (GameObject)GameObject.Instantiate(switchObject);
					buttonCount++;
					temp.transform.position = new Vector3(generateX, -4 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);

					temp = (GameObject)GameObject.Instantiate(cover);
					temp.transform.position = new Vector3(generateX, -2 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
				}
				if(textLines[i][j] == 'P') {
					player.transform.position = new Vector3(generateX, 2 + generateY, generateZ);
				}
				if(textLines[i][j] == 'B') {
					GameObject temp = (GameObject)GameObject.Instantiate(box);
					temp.transform.localScale = new Vector3(2, 2, 2);
					crateCount++;
					temp.transform.position = new Vector3(generateX, 2 + generateY, generateZ);
				}
				if(textLines[i][j] == 'W') {
					GameObject temp = (GameObject)GameObject.Instantiate(wall);
					temp.transform.position = new Vector3(generateX, 6, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 20, tileSize);
				}
				if(textLines[i][j] == 'r') {
					GameObject temp = (GameObject)GameObject.Instantiate(ramp);
					temp.transform.position = new Vector3(generateX, -2 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
				}
				if(textLines[i][j] == 'l') {
					GameObject temp = (GameObject)GameObject.Instantiate(ramp);
					temp.transform.position = new Vector3(generateX, -2 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
					temp.transform.Rotate(0, 180, 0);
				}
				if(textLines[i][j] == 'u') {
					GameObject temp = (GameObject)GameObject.Instantiate(ramp);
					temp.transform.position = new Vector3(generateX, -2 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
					temp.transform.Rotate(0, 90, 0);
				}
				if(textLines[i][j] == 'd') {
					GameObject temp = (GameObject)GameObject.Instantiate(ramp);
					temp.transform.position = new Vector3(generateX, -2 + generateY, generateZ);
					temp.transform.localScale = new Vector3(tileSize, 4, tileSize);
					temp.transform.Rotate(0, -90, 0);
				}
				if(textLines[i][j] == 'A') {
					GameObject temp = (GameObject)GameObject.Instantiate(spider);
					temp.transform.position = new Vector3(generateX, 3 + generateY, generateZ);
					crateCount++;
				}
				if(textLines[i][j] == 'T') {
					GameObject temp = (GameObject)GameObject.Instantiate(turret);
					temp.transform.position = new Vector3(generateX, 3 + generateY, generateZ);
					crateCount++;
				}
				if(textLines[i][j] == 'I') {
					GameObject temp = (GameObject)GameObject.Instantiate(turret);
					temp.transform.position = new Vector3(generateX, 3 + generateY, generateZ);
				}
				if(textLines[i][j] == 'K') {
					GameObject temp = (GameObject)GameObject.Instantiate(kyle);
					temp.transform.position = new Vector3(generateX, 3 + generateY, generateZ);
					crateCount++;
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
		if (pressesLeft == 0) {
			ScoreKeeper.room2++;
			PauseButtonController.finished = true;
		}
		if (gameOver) {
			PauseButtonController.gameOver = true;
		}
		pressesLeftText.text = "Presses Left: " + pressesLeft;
	}
}
