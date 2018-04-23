using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCarKeys : MonoBehaviour {
    public GameObject[] Locations;
    // Use this for initialization
    void Start () {
        int RandomKeyLocation = Random.Range(0, 10);
        Locations[RandomKeyLocation].GetComponent<Puzzles>().CarKeys = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
