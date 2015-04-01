using UnityEngine;
using System.Collections;

public class GameLobbyManager : MonoBehaviour {

	public static int level;
	public static int room1;
	public static int room2;
	public static int room3;
	public static int room4;
	public static int room5;

	public GameObject enddoor;
	public GameObject door1;
	public GameObject door2;
	public GameObject door3;
	public GameObject door4;
	public GameObject door5;

	// Use this for initialization
	void Start () {
		level = 1;
		room1 = 0;
		room2 = 0;
		room3 = 0;
		room4 = 0;
		room5 = 0;
		Instantiate (door1, new Vector3(0.0f, 0.0f, 14.75f), Quaternion.identity); 
		Instantiate (door2, new Vector3(12.5f, 0.0f, 14.75f), Quaternion.identity); 
		Instantiate (door3, new Vector3(25.0f, 0.0f, 14.75f), Quaternion.identity); 
		Instantiate (door4, new Vector3(10.0f, 0.0f, -14.75f), Quaternion.identity); 
		Instantiate (door5, new Vector3(20.0f, 0.0f, -14.75f), Quaternion.identity); 

	}
	
	// Update is called once per frame
	void Update () {
		if (room1 == level && room2 == level && room3 == level && room4 == level && room5 == level) {
			Instantiate(enddoor, new Vector3(-2.25f, 0.0f, 0.0f), Quaternion.identity);
			level++;
		}
	}
}
