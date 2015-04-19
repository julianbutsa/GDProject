using UnityEngine;
using System.Collections;

public class PowerReceiver : MonoBehaviour {
	public bool receivingPower;
	// Use this for initialization
	void Start () {
		receivingPower = false;
		if (GetComponentInParent<NodeHandler> () != null) {
			GetComponentInParent<NodeHandler> ().receivers.Add (this);
		} else if (GetComponentInParent<MP_DoorGoal> () != null) {
			GetComponentInParent<MP_DoorGoal> ().receivers.Add (this);
		} else if (GetComponentInParent<goalScript> () != null) {
			GetComponentInParent<goalScript> ().receivers.Add (this);
		} else if (GetComponentInParent<MP3_PowerEnabler> () != null) {
			Debug.Log("Added to MP3 Power Enabler");
			GetComponentInParent<MP3_PowerEnabler>().receivers.Add (this);
		}

	}
	
	// Update is called once per frame
	void Update () {
	}
}
