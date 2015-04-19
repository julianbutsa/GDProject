using UnityEngine;
using System.Collections;

public class PlatMove5 : MonoBehaviour {
	
	public float current;
	public float min1;
	public float max1;
	public Vector3 c;
	public Vector3 t;
	public float timer;
	public float flag1 = 0f;
	
	void Start () {
		current = transform.position.x;
		max1 = transform.position.x;
		min1 = transform.position.x - 10;
		
		c = new Vector3 (current, transform.position.y, transform.position.z);
		current = current-10;
		t = new Vector3 (current, transform.position.y, transform.position.z);
	}

	void Update () {
		timer += Time.deltaTime;
		transform.position = Vector3.Lerp(c, t, timer/5f);
		
		if (timer >= 5f && flag1 == 0) {
			flag1 = 1;
			timer = 0;
			c = new Vector3 (current, transform.position.y, transform.position.z);
			current = current+10;
			t = new Vector3 (current, transform.position.y, transform.position.z);
		}
		if (timer >= 5f && flag1 == 1) {
			flag1 = 0;
			timer = 0;
			c = new Vector3 (current, transform.position.y, transform.position.z);
			current = current-10;
			t = new Vector3 (current, transform.position.y, transform.position.z);
		}
	}
	
}
