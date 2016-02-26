using UnityEngine;
using System.Collections;

public class platform_updown : MonoBehaviour {

	public int speed = 2;
	public int time = 0;
	public int timer = 399;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time ++;
		if (time > timer) {
			time = 0;
			speed = -speed;
		}
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, speed);
	}
}
