using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class goalScript : MonoBehaviour, NodeHand{

	public ArrayList receivers;
	// Use this for initialization
	void Start () {
		receivers = new ArrayList ();
	}
	
	// Update is called once per frame
	void Update () {
		if (completed ()) {
			//insert level completed action here.
			goalAction ();		
		}
	}

	public void goalAction(){
		Application.LoadLevel (0);
	}

	public void addToList(PowerReceiver p){
		receivers.Add (p);
	}

	public bool completed(){
		foreach (PowerReceiver p in receivers) {
			if (!p.receivingPower) {
				return false;
			}	
		}
		return true;
	}
	
}
