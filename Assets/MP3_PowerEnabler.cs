using UnityEngine;
using System.Collections;

public class MP3_PowerEnabler : MonoBehaviour {

	public GameObject psource;
	public ArrayList receivers;

	// Use this for initialization
	void Start () {
//		psource.GetComponent<PSourceScript> ().enabled = false;
		receivers = new ArrayList ();
	}
	
	// Update is called once per frame
	void Update () {
		foreach (PowerReceiver p in receivers) {
			if (p.receivingPower) {
				Debug.Log ("got power");
				psource.GetComponentInChildren<PSourceScript>().isActive = true;
			}else{
				psource.GetComponentInChildren<PSourceScript>().isActive = false;
			}
		}
	}

}
