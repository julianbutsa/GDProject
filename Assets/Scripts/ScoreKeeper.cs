using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public static int level;
	public static int room1;
	public static int room2;
	public static int room3;
	public static int room4;
	public static int room5;
	


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		level = 1;
		room1 = 0;
		room2 = 0;
		room3 = 0;
		room4 = 0;
		room5 = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
