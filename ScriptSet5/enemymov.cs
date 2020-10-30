using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymov : MonoBehaviour {

	private Vector3 offset;
	public GameObject target;
	private Rigidbody rb;
	public float enemyspeed=100f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (offset*enemyspeed*Time.deltaTime);
		offset = target.transform.position - transform.position;
	}
}
