using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour {

	private float enemyHealth=100.0f;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponentInChildren<Animator> ();
		anim.SetBool ("isRunning", true);
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth <= 0) {
			anim.SetBool ("isRunning", false);
			anim.SetBool ("isDead", true);
			mywait ();
			Destroy (this.gameObject, 0.5f);

		}
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Bullet")) {
			enemyHealth -= 25.0f;
		}
	}
	IEnumerator mywait()
	{
		yield return new WaitForSeconds (3);
	}
}
