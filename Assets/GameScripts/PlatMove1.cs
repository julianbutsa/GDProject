using UnityEngine;
using System.Collections;

public class PlatMove1 : MonoBehaviour {
	
	public float min = 2f;
	public float max = 3f;

	void Start () {
		min = transform.position.z;
		max = transform.position.z+10;
	}
	
	void Update () {
		transform.position =new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time*2,max-min)+min);
	}

}
