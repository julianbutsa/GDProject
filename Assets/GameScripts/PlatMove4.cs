using UnityEngine;
using System.Collections;

public class PlatMove4 : MonoBehaviour {

	public float current;
	public float min1;
	public float max1;
	public Vector3 c;
	public Vector3 t;
	public float timer;
	public float flag1 = 0f;

	void Start () {
		current = transform.position.z;
		max1 = transform.position.z;
		min1 = transform.position.z - 10;

		c = new Vector3 (transform.position.x, transform.position.y, current);
		current = current-10;
		t = new Vector3 (transform.position.x, transform.position.y, current);
	}
	
	void Update () {
		timer += Time.deltaTime;
		transform.position = Vector3.Lerp(c, t, timer/5f);

		if (timer >= 5f && flag1 == 0) {
			flag1 = 1;
			timer = 0;
			c = new Vector3 (transform.position.x, transform.position.y, current);
			current = current+10;
			t = new Vector3 (transform.position.x, transform.position.y, current);
		}
		if (timer >= 5f && flag1 == 1) {
			flag1 = 0;
			timer = 0;
			c = new Vector3 (transform.position.x, transform.position.y, current);
			current = current-10;
			t = new Vector3 (transform.position.x, transform.position.y, current);
		}
	}

}
