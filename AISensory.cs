using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISensory : MonoBehaviour {
	public float sightRange;
	public float fieldOfVision = 45.0f;

	public GameObject target;

	Ray rayToTarget = new Ray();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (CanSee(target));
		CanSee (target);

	}


	//Bool to see if we can see the player. 
	public bool CanSee(GameObject target)
	{
		Vector3 targetPosition = target.transform.position;

		//Find vector from AI to Target. 
		Vector3 distanceToTarget = targetPosition - transform.position;

		//Find angle between direction AI is facing vs. vector to target.
		float angleToTarget = Vector3.Angle(distanceToTarget, transform.forward);

		//If that angle is less than our field of view
		if (angleToTarget < fieldOfVision) {
			rayToTarget.origin = transform.position;
			rayToTarget.direction = distanceToTarget;
			RaycastHit hitInfo;

			if (Physics.Raycast (rayToTarget, out hitInfo, sightRange)) {
				if (hitInfo.collider.gameObject == target) {
					//return true.
					Debug.Log("1");
					return true;
				}
			}
		} 
		return false;
	}
}
