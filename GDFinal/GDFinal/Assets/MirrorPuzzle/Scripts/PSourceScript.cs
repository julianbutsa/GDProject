using UnityEngine;
using System.Collections;

public class PSourceScript : MonoBehaviour {
	Ray thisray;
	RaycastHit hitting;
	public LayerMask lmask;
	public bool isActive = false;
	public GameObject hitObject;

	// Use this for initialization
	void Start () {
		hitObject = null;
		lmask = 1 << 8;
		//thisray  = new Ray(gameObject.transform.position, GetComponent<Transform>().rotation* transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {

		if (isActive) {
			renderer.material.color = Color.green;		
		
		Debug.DrawRay (transform.position, transform.rotation* Vector3.right*100f);
		//if (isActive) {
		if (Physics.Raycast (transform.position, transform.rotation* Vector3.right*100f, out hitting, lmask)) {

				if (hitting.collider.tag.Equals ("Node1")) {
					renderer.material.color = Color.red;
					hitObject = hitting.collider.gameObject;
					hitObject.GetComponent<PowerReceiver>().receivingPower = true;
				} else {
					if(hitObject != null){
						hitObject.GetComponent<PowerReceiver>().receivingPower = false;
						hitObject = null;
					}
				}
				} else {
				if(hitObject != null){
					hitObject.GetComponent<PowerReceiver>().receivingPower = false;
					hitObject = null;
				}
			}
		} else {
			renderer.material.color = Color.grey;		
		}
		//}
	}



}
