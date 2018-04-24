using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rjoystickcontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var angH = Input.GetAxis("RightH") * 60;
        var angV = Input.GetAxis("RightV") * 45;
        transform.localEulerAngles = new Vector3(angV, angH, 0);
    }
}
