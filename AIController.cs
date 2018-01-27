using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

	public enum AIStates {Idle,Patrol,Chase,Attack};

	public AISensory AIsense;
	public AIStates AiState;
	public Movement AiMove;

	private Waypoint waypoint;
	private int currentWaypoint;
	private GameObject player;

	// Use this for initialization
	void Start () {
		AIsense = GetComponent<AISensory> ();
		AiMove = GetComponent<Movement> ();
		waypoint = GetComponent<Waypoint> ();
		player = GetComponent<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (AiState) 
		{
		case AIStates.Idle:
			Idle ();
			break;
		case AIStates.Patrol:
			Patrol ();
			break;
		case AIStates.Chase:
			Chase ();
			break;
		}
	}
	void Idle(){
		//Do nothing. 
		StartCoroutine(IdleTimer());
		Debug.Log ("Started Timer: ");
		//Play Idle Animation. 
	}
	void Patrol()
	{
		//Move along waypoints. 
		StopCoroutine (IdleTimer ());
		Debug.Log ("Stopped Timer: ");
		StartCoroutine (PatrolTImer ());
		Debug.Log ("Started Patrol Timer");

		//if (AIsense.CanSee(player)) {
		//	Debug.Log ("Switched to Chase");
		//	AiState = AIStates.Chase;
		// StopCoroutine(PatrolTimer());
		//}
	}

	void Chase()
	{
		
	}


	IEnumerator IdleTimer()
	{
		yield return new WaitForSeconds (5);
		AiState = AIStates.Patrol;
	}
	IEnumerator PatrolTImer()
	{
		yield return new WaitForSeconds (10);
		AiState = AIStates.Idle;
	}
}
