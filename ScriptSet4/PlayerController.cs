using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator anim;
	private Rigidbody2D rb2d;
	//private float speed=10.0f;

	public float movespeed=2f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, 0.0f);
		/*if (Input.GetKeyDown ("space")) {
			anim.SetTrigger("isJumping");
			rb2d.AddForce (movement * speed);
		}*/
		rb2d.AddForce (movement * movespeed * Time.deltaTime);
	}
}
