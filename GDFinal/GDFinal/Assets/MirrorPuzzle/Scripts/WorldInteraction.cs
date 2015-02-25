using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour {

	public NodeHandler useableObject;
	// Use this for initialization
	void Start () {
		useableObject = null;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && useableObject != null)
			useableObject.rotateNode ();
	}
	
}
