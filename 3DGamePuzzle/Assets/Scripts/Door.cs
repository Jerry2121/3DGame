using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {


    //Make an empty game object and call it "Door"
    //Rename your 3D door model to "Body"
    //Parent a "Body" object to "Door"
    //Make sure thet a "Door" object is in left down corner of "Body" object. The place where a Door Hinge need be
    //Add a box collider to "Door" object and make it much bigger then the "Body" model, mark it trigger
    //Assign this script to a "Door" game object that have box collider with trigger enabled
    //Press "f" to open and to close the door
    //Make sure the main character is tagged "player"

    // Smothly open a door
    public float smooth = 2.0f;
    public float DoorOpenAngle = 90.0f;
    private bool open = false;
    private bool enter = false;
    private Vector3 defaultRot;
    private Vector3 openRot;

    void Start()
    {
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
    }

    //Main function
    void Update()
    {
        if (open)
        {
            //Open door
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
        }
        else
        {
            //Close door
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
        }

        if (Input.GetKeyDown("e") && enter)
        {
            open = !open;
        }
    }

    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'E' to open the door");
        }
    }

    //Activate the Main function when player is near the door
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = true;
        }
        if (collision.gameObject.tag == "Spooky")
        {
            open = !open;
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
            Debug.Log("To Spooky");
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
