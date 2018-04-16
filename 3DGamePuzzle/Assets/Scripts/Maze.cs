using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour {

    public GameObject Player;
    //public GameObject Go;
    public Vector3 startPos;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Maze") {

            transform.position = new Vector3(100, -100, 100);
            Debug.Log("fnhdbgfuhcbedwgfy");

        }

    }
}
