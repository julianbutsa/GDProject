using UnityEngine;
using System.Collections;

public class MovePlat : MonoBehaviour {

	void Start () {
	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider t)
	{
		if (t.gameObject.tag == "movePlat")
		{
			gameObject.transform.parent = t.gameObject.transform;
		}

	}
	
	void OnTriggerExit(Collider t)
	{
		if (t.gameObject.tag == "movePlat")
		{
			gameObject.transform.parent = null;
		}
	}
}
