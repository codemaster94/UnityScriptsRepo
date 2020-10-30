using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlscript : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("isJumping", true);
		}
		if (Input.GetMouseButtonDown (0)) {
			anim.SetBool ("isAttacking", true);
		
		}
	}
}
