﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {
    public int catagory;
    public int value;
   

	// Use this for initialization
	void Start () {
       
       
	}
	
	// Update is called once per frame
	void Update () {
        print("catagory" + catagory + " value   " + value);
    }
}