using UnityEngine;
using System.Collections;

public class PSourceScript : MonoBehaviour {
	Ray thisray;
	RaycastHit hitting;
	public LayerMask lmask;
	public bool isActive = false;
	public GameObject hitObject;
	public LineRenderer r;

	// Use this for initialization
	void Start () {
		r = GetComponent<LineRenderer> ();
		r.SetWidth (0.2f, 0.2f);
		r.SetPosition (0, transform.parent.transform.position);
		r.SetPosition (1, transform.parent.transform.position);
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
				r.SetPosition(1, hitting.collider.gameObject.transform.position);

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
			r.SetPosition(1, transform.parent.transform.position);
			renderer.material.color = Color.grey;		
		}
		//}
	}



}
