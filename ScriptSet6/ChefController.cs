using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefController : MonoBehaviour {


	private Rigidbody2D rb2d;
	public float moveSpeed=10f;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D)) {
			rb2d.AddForce (Vector2.right*Time.deltaTime*moveSpeed);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A)) {
			rb2d.AddForce (Vector2.left*Time.deltaTime*moveSpeed);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) {
			rb2d.AddForce (Vector2.up*Time.deltaTime*moveSpeed);
		}
	}
}
