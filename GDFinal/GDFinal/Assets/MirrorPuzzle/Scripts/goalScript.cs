using UnityEngine;
using System.Collections;

public class goalScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponentInChildren<PowerReceiver> ().receivingPower) {
			this.goalAction();		
		}
	}

	public void goalAction(){
		Application.LoadLevel (0);
	}


	
}
