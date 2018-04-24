using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour {
    public bool one = false;
    public bool two = false;
    public bool three = false;
    public bool four = false;
    public bool five = false;
    public bool six = false;
    public bool seven = false;
    public bool eight = false;
    public bool nine = false;
    public bool zero = false;

    // Use this for initialization
    void Start () {
        Debug.Log("Start");

    }

    // Update is called once per frame
    void Update () {
        Debug.Log("Spamming");

    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("boooobsssssddddsfes");

        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Test")
        {
            one = true;
            Debug.Log("Beep");
        }
        if (collision.gameObject.name == "two")
        {
            two = true;
            Debug.Log("Beep");
        }
        if (collision.gameObject.name == "three")
        {
            three = true;
            Debug.Log("Beep");
        }
    }
}
