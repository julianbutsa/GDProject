using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	void OnTriggerEnter(Collider t)
	{
		if (t.gameObject.name == "FallArea")
		{
			Application.LoadLevel("Easy1.1");
		}
	}
}
