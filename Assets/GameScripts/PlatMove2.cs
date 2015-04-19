﻿using UnityEngine;
using System.Collections;

public class PlatMove2 : MonoBehaviour {
	
	public float min = 2f;
	public float max = 3f;
	
	void Start () {
		min = transform.position.x;
		max = transform.position.x+10;
	}
	
	void Update () {
		transform.position =new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
	}
}