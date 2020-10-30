using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingscript : MonoBehaviour {

	public GameObject bullet;
	public float shootingspeed=1100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject instBullet = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;
			Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody> ();
			instBulletRigidbody.AddForce (transform.forward*shootingspeed);
			//instBulletRigidbody.AddForce(instBullet.transform.forward*shootingspeed);

		}

	}
}
