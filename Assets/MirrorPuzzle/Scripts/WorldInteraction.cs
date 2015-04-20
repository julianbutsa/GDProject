using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour {

	public float startx;
	public float starty;
	public float startz;

	public NodeHandler useableObject;
	// Use this for initialization
	void Start () {
		useableObject = null;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && useableObject != null)
			useableObject.rotateNode ();
		if (transform.position.y < -10.0f) {
			transform.position = new Vector3(startx, starty, startz); 		
		}
	}
	
}
