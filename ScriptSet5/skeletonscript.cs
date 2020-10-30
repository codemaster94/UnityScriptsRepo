using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonscript : MonoBehaviour {

	//private Animator anim;
	//private Rigidbody rb;
	private Vector3 offset;
	public GameObject target;
	public float skeletonspeed=25f;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		//anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		offset = target.transform.position - transform.position;
		//float angle = Mathf.Atan2 (offset.x, offset.z) * Mathf.Rad2Deg;
		//anim.SetBool ("isRunning", true);
		transform.Translate(offset.normalized*Time.deltaTime*skeletonspeed);
		//transform.Rotate (0, angle, 0);
		//rb.AddForce (offset*skeletonspeed*Time.deltaTime);
	}
}
