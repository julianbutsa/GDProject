using UnityEngine;
using System.Collections;

public class PlatMove3 : MonoBehaviour {
	
	public float min = 2f;
	public float max = 3f;
	
	void Start () {
		min = transform.position.y;
		max = transform.position.y+10;
	}
	
	void Update () {
		transform.position =new Vector3(transform.position.x, Mathf.PingPong(Time.time*2,max-min)+min, transform.position.z);
	}
}
