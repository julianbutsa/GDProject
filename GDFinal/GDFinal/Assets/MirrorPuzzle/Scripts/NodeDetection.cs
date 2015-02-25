using UnityEngine;
using System.Collections;

public class NodeDetection : MonoBehaviour {
	Ray thisray;
	RaycastHit hitting;
	public int direction;
	public bool isActive;

	// Use this for initialization
	void Start () {
		isActive = false;
		thisray  = new Ray(gameObject.transform.position, Vector3.forward);
		//hitting = new RaycastHit ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (Vector3.zero, Vector3.forward);
		if (Physics.Raycast (thisray, out hitting)) {
			if(hitting.collider.tag.Equals ("Node1")){
				isActive = true;
				renderer.material.color = Color.red;
			}
			else
				isActive = false;
		} else {
			isActive = false;
		}
	}
	
}
