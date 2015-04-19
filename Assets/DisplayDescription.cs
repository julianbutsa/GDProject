using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayDescription : MonoBehaviour {
	public Text description;
	// Use this for initialization
	void Start () {
		description = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetText(string t){
		description.text = t;
	}
}
