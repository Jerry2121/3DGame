using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class ObjectiveRayCasts : MonoBehaviour {
    public GameObject ObjectiveText;
    // Use this for initialization
    public Transform player;
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        //layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.collider.gameObject.tag == "Key")
            {
                ObjectiveText.GetComponent<Text>().text = ("Objective: What does this key go to? And who would leave this key out anyway. Looks very important.");
            }
            if (hit.collider.gameObject.tag == "Test")
            {
                ObjectiveText.GetComponent<Text>().text = ("Objective: Blah");
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.white);
        }
    }
}
