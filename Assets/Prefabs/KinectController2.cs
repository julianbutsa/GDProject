using UnityEngine;
using System.Collections;

public class KinectController2 : MonoBehaviour {

	float oldLeftFootY;
	float oldRightFootY;
	float newLeftFootY = -1;
	float newRightFootY = -1;

	float leftFootUp = -1f;
	float rightFootUp = -1f;
	public float turnSpeed = 30f;

	// Use this for initialization
	void Start () {
		oldLeftFootY = -100f;
		oldRightFootY = -100f;
		newLeftFootY = -1f;
		newRightFootY = -1f;

		leftFootUp = -1f;
		rightFootUp = -1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (leftFootUp >= 0f)
						leftFootUp -= Time.deltaTime;
		if (rightFootUp >= 0f)
						rightFootUp -= Time.deltaTime;

		if (KinectClient.KINECT_CONNECTED && KinectClient.SKELETON_TRACKED) {
			if(KinectClient.Joints[KinectClient.JointType.ShoulderCenter].x <= -.1f &&
			   KinectClient.Joints[KinectClient.JointType.ShoulderCenter].x >= -.9f)
				transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
			if(KinectClient.Joints[KinectClient.JointType.ShoulderCenter].x >=  .3f &&
			   KinectClient.Joints[KinectClient.JointType.ShoulderCenter].x <=  .9f)
				transform.Rotate(0, turnSpeed * Time.deltaTime, 0);

			oldLeftFootY = newLeftFootY;
			oldRightFootY = newRightFootY;
			newLeftFootY = KinectClient.Joints[KinectClient.JointType.KneeLeft].y;
			newRightFootY = KinectClient.Joints[KinectClient.JointType.KneeRight].y;
			if(newLeftFootY != oldLeftFootY && newLeftFootY >= -.6f && newLeftFootY < 0f)
				leftFootUp = .25f;
			if(newRightFootY != oldRightFootY && newRightFootY >= -.6f && newRightFootY < 0f)
				rightFootUp = .25f;
		}
	}

	public bool isKinectJumping() {
		return KinectClient.KINECT_CONNECTED && leftFootUp >= 0f && rightFootUp >= 0f;
	}
	public bool isKinectWalking() {
		return KinectClient.KINECT_CONNECTED && (leftFootUp > 0f || rightFootUp > 0f);
	}
}
