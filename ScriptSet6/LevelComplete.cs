﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			//Debug.Log ("Destination Reached! You win!");
			SceneManager.LoadScene("WinMenu");
		}

	}
}
