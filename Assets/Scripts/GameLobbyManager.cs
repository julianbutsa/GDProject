using UnityEngine;
using System.Collections;

public class GameLobbyManager : MonoBehaviour {

	public GameObject enddoor;
	public GameObject door1;
	public GameObject door2;
	public GameObject door3;
	public GameObject door4;
	public GameObject door5;

	private Object d1;
	private Object d2;
	private Object d3;
	private Object d4;
	private Object d5;
	private int end;

	// Use this for initialization
	void Start () {
		end = 0;
		d1 = Instantiate (door1, new Vector3(0.0f, 1.5f, 14.75f), Quaternion.identity); 
		d2 = Instantiate (door2, new Vector3(12.5f, 1.5f, 14.75f), Quaternion.identity); 
		d3 = Instantiate (door3, new Vector3(25.0f, 1.5f, 14.75f), Quaternion.identity); 
		d4 = Instantiate (door4, new Vector3(10.0f, 1.5f, -14.75f), Quaternion.identity); 
		d5 = Instantiate (door5, new Vector3(20.0f, 1.5f, -14.75f), Quaternion.identity); 

	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreKeeper.room1 == ScoreKeeper.level && d1) {
			Destroy (d2);
		}
		if (ScoreKeeper.room2== ScoreKeeper.level && d2) {
			Destroy (d3);
		}
		if (ScoreKeeper.room3 == ScoreKeeper.level && d3) {
			Destroy (d1);
		}
		if (ScoreKeeper.room4 == ScoreKeeper.level && d4) {
			Destroy (d5);
		}
		if (ScoreKeeper.room5 == ScoreKeeper.level && d5) {
			Destroy (d4);
		}
		if (ScoreKeeper.room1 == ScoreKeeper.level && ScoreKeeper.room2 == ScoreKeeper.level && ScoreKeeper.room3 == ScoreKeeper.level && ScoreKeeper.room4 == ScoreKeeper.level && ScoreKeeper.room5 == ScoreKeeper.level && end == 0) {
			Invoke ("End", 0.0f);
			/*Instantiate(enddoor, new Vector3(-2.25f, 0.0f, 0.0f), Quaternion.identity);*/
			end = 1;
		}
	}

	void End(){
		ScoreKeeper.level++;
		Application.LoadLevel ("MainMenuScene");
	}
}
