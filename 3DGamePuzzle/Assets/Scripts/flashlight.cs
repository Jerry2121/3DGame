﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour {
    public GameObject Spotlight;
    public bool StartOn;
    public bool On;
	// Use this for initialization
	void Start () {
        if (StartOn == true)
        {
            Spotlight.GetComponent<Light>().enabled = true;
            On = true;
        }
        if (StartOn == false)
        {
            Spotlight.GetComponent<Light>().enabled = false;
            On = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F) && On == false)
        {
            Spotlight.GetComponent<Light>().enabled = true;
            On = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && On == true)
        {
            Spotlight.GetComponent<Light>().enabled = false;
            On = false;
        }
    }
}
