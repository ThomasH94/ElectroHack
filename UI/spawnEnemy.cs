using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour 
{
	public GameObject e;
	public GameObject[] spawn;
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.Alpha1)) 
		{
			Instantiate (e, new Vector3(spawn[0].transform.position.x,spawn[0].transform.position.y,spawn[0].transform.position.z),Quaternion.identity);
			print(spawn[0].name);
		}	
		if (Input.GetKeyUp (KeyCode.Alpha2)) 
		{
			Instantiate (e, new Vector3(spawn[1].transform.position.x,spawn[1].transform.position.y,spawn[1].transform.position.z),Quaternion.identity);
			print(spawn[1].name);
		}
		if (Input.GetKeyUp (KeyCode.Alpha3)) 
		{
			Instantiate (e, new Vector3(spawn[2].transform.position.x,spawn[2].transform.position.y,spawn[2].transform.position.z),Quaternion.identity);
			print(spawn[2].name);
		}
	}
}
