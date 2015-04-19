using UnityEngine;
using System.Collections;

public class CharPlat : MonoBehaviour {
	
	void Start () {
	}
	
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider t)
	{
		if (t.gameObject.tag == "Plat")
		{
			gameObject.transform.parent = t.gameObject.transform;
		}
		
	}
	
	void OnTriggerExit(Collider t)
	{
		if (t.gameObject.tag == "Plat")
		{
			gameObject.transform.parent = null;
		}
	}
}
