using UnityEngine;
using System.Collections;

public class platform_leftright : MonoBehaviour {

	public int speed = -5;
	public int time = 0;
	public int timer = 40;
	private bool left = false;


		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			time ++;
			if (time > timer) {
				time = 0;
				if (left){
					speed = 1;
					timer = 200;
					left = false;
			}
				else if (!left){
					speed = -5;
					timer = 40;
					left = true;

			}
			}
			if (time > -1){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		}
	}