using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class MP_DoorGoal : MonoBehaviour , NodeHand{
	public GameObject door;
	public ArrayList receivers;

	// Use this for initialization
	void Start () {
	
		this.receivers = new ArrayList ();
	}
	
	// Update is called once per frame
	void Update () {
		foreach (PowerReceiver p in receivers) {
			if (p.receivingPower) {
				Debug.Log("Goal has power");
				this.goalAction();		
				this.enabled = false;
			}
		}

	}

	
	public void goalAction(){
		door.GetComponent<MP_DoorScript> ().openDoor();
	}

	public void addToList(PowerReceiver p){
		receivers.Add (p);
	}
}
