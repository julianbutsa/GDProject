using UnityEngine;
using System.Collections;

public class Fall2 : MonoBehaviour {
	
	void OnTriggerEnter(Collider t)
	{
		if (t.gameObject.name == "FallArea")
		{
			Application.LoadLevel("Medium1.1");
		}
	}
}
