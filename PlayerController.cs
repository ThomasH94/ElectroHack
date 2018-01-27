using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Movement playerMov;
	private AIController Ai;

	// Use this for initialization
	void Start () {
		playerMov = GetComponent<Movement> ();
		Ai = GetComponent<AIController> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Movement for player. 
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * playerMov.turnSpeed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * playerMov.moveSpeed;
		transform.Rotate (0, x, 0);
		transform.Translate (0, 0, z);

		//Checking input for hack function. 
		if(Input.GetKeyDown(KeyCode.Mouse0)){
		}
	}

	public void Hack()
	{
	}
}
