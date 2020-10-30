using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller2D))]

public class Player : MonoBehaviour {

	//added this now
	private bool facingRight;

	public float jumpHeight=4;
	public float timeToJumpApex = 0.4f;
	float accelerationTimeAirborne=0.2f;
	float accelerationTimeGrounded=0.1f;

	float moveSpeed=6;

	float gravity;
	float jumpVelocity;
	Vector3 velocity;
	float velocityXSmoothing;

	Controller2D controller;

	void Start()
	{
		controller = GetComponent<Controller2D> ();

		//added this part now
		facingRight=true;


		gravity = -(2 * jumpHeight) / Mathf.Pow (timeToJumpApex, 2);
		jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
		print ("Gravity: " + gravity + " Jump Velocity: " + jumpVelocity);
	}

	void Update()
	{

		if (controller.collisions.above || controller.collisions.below) {
			velocity.y = 0;
		}

		if ((Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && controller.collisions.below) {
			velocity.y = jumpVelocity;
		}

		//I added this part and I will comment where it is over
		if (velocity.x < 0 && facingRight) {
			Vector3 temp = transform.localScale;
			temp.x *= -1;
			transform.localScale = temp;
			facingRight = false;
		}
		if (velocity.x > 0 && !facingRight) {
			Vector3 temp = transform.localScale;
			temp.x *= -1;
			transform.localScale = temp;
			facingRight = true;
		}
		//It gets over here

		Vector2 input = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		float targetVelocityX = input.x * moveSpeed;
		velocity.x = Mathf.SmoothDamp (velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below)?accelerationTimeGrounded:accelerationTimeAirborne);
		velocity.y += gravity * Time.deltaTime;
		controller.Move (velocity * Time.deltaTime);
	}
}





























