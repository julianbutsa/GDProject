using UnityEngine;
using System.Collections;

public class GoalReceiver : MonoBehaviour {
	public bool receivingPower;
	// Use this for initialization
	void Start () {
		receivingPower = false;
		GetComponentInParent<MP_DoorGoal> ().receivers.Add (this);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
