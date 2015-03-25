using UnityEngine;
using System.Collections;

public class MirrorPuzzleStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<ScriptEnabler>().enablePowerNodeController(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
