using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {

	//public GameObject duplication;
	public int Health=100;
	public int currentHealth;

	public HealthBarScript healthBar;
	//private Transform mytomb;
	// Use this for initialization
	void Start () {
		//mytomb = this.transform;
		currentHealth=Health;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject != null) {
			if (Health <= 0) {
				DeathMethod ();
				Destroy (this.gameObject);

			}

		} 
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.CompareTag("Duplicate")) {
			Health -= 3;
			//Debug.Log(Health);
			healthBar.SetHealth(Health);
			//GameObject.Instantiate (duplication, mytomb);
		}
		if (other.gameObject.CompareTag ("Enemy")) {
			Health -= 25;
			Debug.Log (Health);
		}
	}
	void DeathMethod()
	{
		SceneManager.LoadScene ("RestartMenu");
	}
}
