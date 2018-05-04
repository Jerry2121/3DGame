using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThis : MonoBehaviour {

    // Use this for initialization
    public float zRotate = 0;
    public bool zMove = false;
 
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (zMove == true && Input.GetKey(KeyCode.RightArrow) || zMove == true && Input.GetAxis("Dial") > 0)
        {
            transform.Rotate(0, 0, zRotate);
        }
        if (zMove == true && Input.GetKey(KeyCode.LeftArrow) || zMove == true && Input.GetAxis("Dial") < 0)
        {   
            transform.Rotate(0, 0, -zRotate);
        }


    }
}

