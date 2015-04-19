using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class NodeHandler: MonoBehaviour, NodeHand{
	// Use this for initialization
	public ArrayList receivers;


	void Start () {
		renderer.material.color = Color.black;
		receivers = new ArrayList ();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (this.GetComponentInChildren<PowerReceiver> ().receivingPower);
		foreach (PowerReceiver p in receivers) {
			if (p.receivingPower) {
				this.GetComponentInChildren<PSourceScript> ().isActive = true;	
				break;
			} else {
				this.GetComponentInChildren<PSourceScript> ().isActive = false;		
			}	
		}

	
	}
	
	void OnTriggerEnter(Collider c){
		if(c.tag.Equals ("Player")){
			c.GetComponent<WorldInteraction>().useableObject = this;
		}
	}

	void OnTriggerExit(Collider c){
		if(c.tag.Equals ("Player")){
			c.GetComponent<WorldInteraction>().useableObject = null;
		}
	}


	public void rotateNode(){
		transform.Rotate (new Vector3 (0, 90, 0));
			
	}

	public void addToList(PowerReceiver p){
		this.receivers.Add (p);
	}
}
