using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.name == "1")
        {
            transform.parent.GetComponent<LightSwitches>().Set1();
            Debug.Log("1 set");
        }
        if (collision.gameObject.tag == "Player" && gameObject.name == "2")
        {
            transform.parent.GetComponent<LightSwitches>().Set2();
            Debug.Log("2 set");

        }
        if (collision.gameObject.tag == "Player" && gameObject.name == "3")
        {
            transform.parent.GetComponent<LightSwitches>().Set3();
            Debug.Log("3 set");

        }
        if (collision.gameObject.tag == "Player" && gameObject.name == "4")
        {
            transform.parent.GetComponent<LightSwitches>().Set4();
            Debug.Log("4 set");

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
