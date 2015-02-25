using UnityEngine;
using System.Collections;

public class NodeHandler : MonoBehaviour {
	// Use this for initialization
	

	void Start () {
		renderer.material.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (this.GetComponentInChildren<PowerReceiver> ().receivingPower);
		if (this.GetComponentInChildren<PowerReceiver> ().receivingPower) {
			this.GetComponentInChildren<PSourceScript> ().isActive = true;	
		} else {
			this.GetComponentInChildren<PSourceScript> ().isActive = false;		
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
}
