using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicationScript : MonoBehaviour {

	private GameObject obj;
	public GameObject duplicateobj;
	private Transform duplicatePosition;
	public Transform placetospawn;
	float destroytime=5;
	float  spawnspeed=5f;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.transform.CompareTag ("Player")) {
			for (int i = 0; i < 5; i++) {
				GameObject obj=Instantiate (duplicateobj, placetospawn.position, Quaternion.identity) as GameObject;
				Rigidbody objRigidbody=obj.GetComponent<Rigidbody> ();
				objRigidbody.AddForce (Vector3.up*spawnspeed);
				Destroy (obj, destroytime);
			}

		}
	}
}
