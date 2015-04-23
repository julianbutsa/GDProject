
using UnityEngine;
using System.Collections;

public class FinishPlat : MonoBehaviour {
	
	void Start () {
	}
	
	void Update () {
	}
	
	
	void OnTriggerEnter(Collider t)
	{
		if (t.gameObject.tag == "Player") {
						ScoreKeeper.room5++;
						Application.LoadLevel ("MainMenuScene");
				}
	}
}