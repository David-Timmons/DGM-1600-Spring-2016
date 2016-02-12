using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	//player move speed
	public float moveSpeed = 1;
	float moveStart;
	public float moveGain = .5F;
	public float maxMoveSpeed = 5;
	public float jumpHeight = 6;
	float jumpAmount = 0.5F;


	public float GetY(){
		float yy = GetComponent<Rigidbody2D> ().velocity.y;
		return yy;
	}

	public float GetX(){
		float xx = GetComponent<Rigidbody2D> ().velocity.x;
		return xx;
	}

	//ground check
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;



	// Use this for initialization
	void Start () {
		moveStart = moveSpeed;



	}

	void FixedUpdate() {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			if (moveSpeed < maxMoveSpeed){
				moveSpeed = moveSpeed + moveGain;
			}
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetY ());
		} 
		if (Input.GetKey (KeyCode.D)) {
			if (moveSpeed < maxMoveSpeed){
				moveSpeed = moveSpeed + moveGain;
			}
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetY ());
		}
		if (Input.GetKeyDown (KeyCode.Space)&& jumpAmount < 1.5) {
			jumpAmount ++;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetX (), jumpHeight / jumpAmount);
		}
		if (Input.GetKey (KeyCode.A)) {

		} else if (Input.GetKey (KeyCode.D)) {

		}
		else {
			if (moveSpeed > moveGain + moveStart){
				moveSpeed = moveSpeed - moveGain;
			}
			else {
				moveSpeed = moveStart;
			}
		}
		if (moveSpeed > maxMoveSpeed) {
			moveSpeed = maxMoveSpeed;
		}
		if (grounded && jumpAmount != 0) {
			jumpAmount = 0;
		}
	}
}