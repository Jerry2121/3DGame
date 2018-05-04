using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintings : MonoBehaviour {
    private bool enter = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && enter == true || Input.GetKeyDown(KeyCode.Joystick1Button2) && enter == true)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().mass = 10.0f;

            }
        }
	}
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = true;
        }
    }
}
