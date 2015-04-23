using UnityEngine;
using System.Collections;

public class MoveTile : MonoBehaviour {
	
	public GameObject slot;
	float xtemp;
	float ytemp;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnMouseDown(){
		//If theDistance==1 between tiles then swap tiles
		Debug.Log (Vector3.Distance (transform.localPosition, slot.transform.localPosition));
		if(Vector3.Distance(transform.localPosition,slot.transform.localPosition)==1){	
		xtemp = transform.localPosition.x;
			ytemp = transform.localPosition.y;
			transform.localPosition = new Vector3(slot.transform.localPosition.x, slot.transform.localPosition.y, 0);
			slot.transform.localPosition = new Vector3(xtemp, ytemp, 0);
			
		}
		
	}
}﻿