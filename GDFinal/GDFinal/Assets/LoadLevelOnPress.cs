using UnityEngine;
using System.Collections;

public class LoadLevelOnPress : MonoBehaviour {
	public int level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void setLevel(int l){
		this.level = l;
		gameObject.SetActive (true);
	}

	public void loadLevel(){
		Application.LoadLevel (this.level);
	}
}
