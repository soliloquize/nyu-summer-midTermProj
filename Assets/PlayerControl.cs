﻿using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public Material ltMat;
	public Material dkMat;


	void Update () {
	
		if (Input.GetKey(KeyCode.LeftShift)){
			GetComponent<Renderer>().material = dkMat;
		} else {
			GetComponent<Renderer>().material = ltMat;
		}

	}
}
