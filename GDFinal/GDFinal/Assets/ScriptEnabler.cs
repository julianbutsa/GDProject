using UnityEngine;
using System.Collections;

public class ScriptEnabler : MonoBehaviour {

	/*
	 *Disable all scripts at character generation
	 */
	void Start () {
	
		GetComponent<AppearP> ().enabled = false;
		GetComponent<PlayerController> ().enabled = false;
		GetComponent<PlayerControllerPortal> ().enabled = false;
		GetComponent<WorldInteraction> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*
	 * Use these functions to enable the scripts you want to use at level startup.
	 */

	public void enableAppearP(){
		GetComponent<AppearP> ().enabled = true;
	}

	public void enableMattsController(){
		GetComponent<PlayerController> ().enabled = true;
	}

	public void enablePortalController(){
		GetComponent<PlayerControllerPortal> ().enabled = true;
	}

	public void enablePowerNodeController(){
		GetComponent<WorldInteraction> ().enabled = true;
		Debug.Log (GetComponent<WorldInteraction> ().enabled);
	}
}
