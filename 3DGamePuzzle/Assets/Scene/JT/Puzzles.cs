using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzles : MonoBehaviour {
    public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            timer += Time.deltaTime;
            if (timer >= 5)
            {
                Debug.Log("Nothing Was Found.");
                timer = 0;
            }
        }
        else
        {
            timer = 0;
        }
    }
}
