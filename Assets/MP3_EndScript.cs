using UnityEngine;
using System.Collections;

public class MP3_EndScript : MonoBehaviour {

	public GameObject node1;
	public GameObject node2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (node1.GetComponent<PowerReceiver> ().receivingPower && node2.GetComponent<PowerReceiver> ().receivingPower) {
				
			//do whatever to end the level;
			Application.LoadLevel(0);
		}
	}
}
