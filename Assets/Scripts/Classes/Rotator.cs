﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float rotationPower = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(EventHandler.IsPlaying)
			transform.Rotate(new Vector3(0, 0, rotationPower * Time.deltaTime * (EventHandler.LevelCount/2)));
	}
}
