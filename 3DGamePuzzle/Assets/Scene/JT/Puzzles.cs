using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzles : MonoBehaviour {
    public float timer;
    private bool enter = false;

    // Use this for initialization
    void Start () {
		
	}

    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'E' to open the door");
        }
    }

    // Update is called once per frame
    void Update () {

	}
    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKey(KeyCode.E))
        {
            enter = false;

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
