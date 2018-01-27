using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eHealth : MonoBehaviour 
{
	//How many hits an enemy can take
	[SerializeField]
	private int health;
	[SerializeField]
	//UI renderer control
	private Renderer[] healthBar;

	// Use this for initialization
	void Start () 
	{
		//Puts renderers in Array
		healthBar = GetComponentsInChildren<Renderer>();
		health = 3;
	}

	void Update()
	{
		//Debug health points
		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			health++;
			barShow ();
		}
		if (Input.GetKeyUp(KeyCode.DownArrow)) 
		{
			health--;
			barShow ();
		}
	}
	void barShow()
	{
		//Switches images based on health
		switch (health) 
		{
		case 1:
			healthBar [1].enabled = false;
			healthBar [2].enabled = false;
			healthBar [3].enabled = true;
			print (1);
			break;
		case 2:
			healthBar [1].enabled = false;
			healthBar [2].enabled = true;
			healthBar [3].enabled = false;
			print (2);
			break;
		case 3:
			healthBar [1].enabled = true;
			healthBar [2].enabled = false;
			healthBar [3].enabled = false;
			print (3);
			break;
		case 0:
			healthBar [1].enabled = false;
			healthBar [2].enabled = false;
			healthBar [3].enabled = false;
			print (4);
			break;
		}
	}
}
