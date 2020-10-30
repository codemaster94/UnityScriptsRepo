using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollower : MonoBehaviour {

	public GameObject ThePlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<NavMeshAgent> ().SetDestination (ThePlayer.transform.position);
	}
}
