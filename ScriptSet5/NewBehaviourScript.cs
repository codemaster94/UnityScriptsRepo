using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public float rotationRate=360f;
	public float moveSpeed=2f;

	// Use this for initialization
	void Start () {
		
	}
	private void AppyInput(float moveInput,float turnInput)
	{
		Move (moveInput);
		Turn (turnInput);
	}
	// Update is called once per frame
	void Update () {
		float moveAxis = Input.GetAxis ("Vertical");
		float turnAxis = Input.GetAxis ("Horizontal");
		AppyInput(moveAxis, turnAxis);
	}


	private void Move(float mymove)
	{
		transform.Translate (Vector3.forward * mymove * moveSpeed);
	}
	private void Turn(float myrot)
	{
		transform.Rotate (0, myrot * rotationRate * Time.deltaTime, 0);
	}
}
