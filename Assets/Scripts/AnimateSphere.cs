using UnityEngine;
using System.Collections;

public class AnimateSphere : MonoBehaviour {

	public bool movingRight = false;
	public float rightBound = 5.0f;
	public float leftBound = -5.0f;
	public Vector3 currentPosition = new Vector3 (0f, 0f, 0);
	public Vector3 speed = new Vector3 (0.1f,0f,0f);

	// Use this for initialization
	void Start () {
		transform.position = currentPosition;
	}

	// Update is called once per frame
	void Update () {
		if (movingRight) {
			if (currentPosition.x < rightBound) {
				currentPosition = currentPosition + speed;
				print ("one");
			} else {
				movingRight = false;
				currentPosition = currentPosition - speed;
				print ("two");
			}
		} else {
			if (currentPosition.x > leftBound) {
				currentPosition = currentPosition - speed;
				print ("three");
			} else {
				movingRight = true;
				currentPosition = currentPosition + speed;
				print ("four");
			}
		}
		transform.position = currentPosition;
	}
}
