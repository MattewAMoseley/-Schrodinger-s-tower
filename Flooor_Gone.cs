﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Flooor_Gone : MonoBehaviour {
	
	GameObject floorPre;
	GameObject[] floors;
	
	int counter;
	int numFloors = 0;
	
	//int counterL;
	
	bool leave;
	
	// Use this for initialization
	void Start () {
		
		floors = GameObject.FindGameObjectsWithTag("Floor");
		
		
		foreach(GameObject floor in floors)
		{
			numFloors++;
		}
		
		floorPre = floors[0];
		
		counter = 0;
		
		//counterL = 0;
		
		leave = false;
		
	}
	
	void toDisapear()
	{
		if(leave)
		{
			floorPre.GetComponent<Collider2D>().enabled = false;
			floorPre.GetComponent<Renderer>().enabled = false;
			
		}
		else
		{
			floorPre.GetComponent<Collider2D>().enabled = true;
			floorPre.GetComponent<Renderer>().enabled = true;
			
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
		if(counter >= 300)
		{
			if(leave)
			{
				leave = false;
				toDisapear();
				
				counter = 0;
				
				return;
			}
			else
			{
				leave = true;
			}
			
			int inc = 0;
			
			int rand = Random.Range(0, numFloors);
			
			floorPre = floors[rand];
			counter = 0;
			
			toDisapear();
			
		}
		else
		{
			counter++;
		}
	}
}
