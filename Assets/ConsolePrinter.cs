﻿using UnityEngine;
using System.Collections;

public class ConsolePrinter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 location = new Vector2(2.0f, 3.0f); //Distance in meters
		Vector2 homeLocation = new Vector2 (5.0f, 1.0f);
		Vector2 pathToHome = homeLocation - location;

		print ("Welcome to Go Home!");
		print ("A game where you need to find your way back.");
		print ("Distance " + pathToHome);
		print ("Distance to home:" + pathToHome.magnitude);
 
		if (location == homeLocation) {
			print ("I am at home!");
		}

	}
	
	// Update is called once per frame
	void Update () {	
	
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			print ("Left Key Pressed.");
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			print ("Right Key Pressed.");
		}
	}
}
