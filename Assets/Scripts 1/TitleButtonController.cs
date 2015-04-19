using UnityEngine;
using System.Collections;

public class TitleButtonController : MonoBehaviour {
	public void PlayButtonClick() {
		Application.LoadLevel (1);
	}
	public void QuitButtonClick() {
		Application.Quit ();
	}
}
