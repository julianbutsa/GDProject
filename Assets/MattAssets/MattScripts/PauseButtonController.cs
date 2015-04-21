using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseButtonController : MonoBehaviour {
	public static bool finished = false;
	public static bool gameOver = false;
	public GameObject canvas;
	public Button resumeButton;
	public Text text;
	bool pauseHeld = false;
	bool paused = false;

	void Awake() {
		Time.timeScale = 1.0f;
		finished = false;
		gameOver = false;
	}

	void Update() {
		if (Input.GetKey (KeyCode.P) && !pauseHeld)
			paused = !paused;
		pauseHeld = Input.GetKey (KeyCode.P);

		if (paused == true || gameOver == true || finished == true) {
			canvas.SetActive (true);
			if (gameOver) {
				resumeButton.enabled = false;
				text.text = "Game Over!";
			}
			else if (finished) {
				resumeButton.enabled = false;
				text.text = "Level Beaten!";
			}
			else {
				resumeButton.enabled = true;
				text.text = "Paused!";
			}
			Time.timeScale = 0f;
		} else {
			Time.timeScale = 1.0f;
			canvas.SetActive(false);
		}
	}

	public void ResumeButtonClick() {
		paused = false;
	}
	public void RestartButtonClick() {
		if (finished) {
			Time.timeScale = 1f;
			paused = false;
			finished = false;
			gameOver = false;
						Application.LoadLevel ("MainMenuScene");
				} else
						Application.LoadLevel (Application.loadedLevel);
	}
	public void TitleButtonClick() {
		Time.timeScale = 1f;
		paused = false;
		finished = false;
		gameOver = false;
		Application.LoadLevel ("MainMenuScene");
	}
	public void QuitButtonClick() {
		Application.Quit ();
	}
}
