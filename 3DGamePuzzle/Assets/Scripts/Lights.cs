﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {
    public GameObject Spotlight;
    public bool StartOn;
    public bool On;
    private bool enter = false;

    // Use this for initialization
    void Start()
    {
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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && On == false && enter == true || Input.GetKeyDown(KeyCode.Joystick1Button2) && On == false && enter == true)
        {
            Spotlight.GetComponent<Light>().enabled = true;
            On = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && On == true && enter == true || Input.GetKeyDown(KeyCode.Joystick1Button2) && On == true && enter == true)
        {
            Spotlight.GetComponent<Light>().enabled = false;
            On = false;
        }
    }
    void OnGUI()
    {
        if (enter == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 300, 30), "Press 'E' to toggle the light or 'X' on a controller");

        }
    }
    //Activate the Main function when player is near the door
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = true;
        }
    }

    //Deactivate the Main function when player is go away from door
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = false;
        }
    }
}
