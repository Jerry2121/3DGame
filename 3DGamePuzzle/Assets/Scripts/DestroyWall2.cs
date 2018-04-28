using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("Puzzle3complete") == 1 && PlayerPrefs.GetInt("Puzzle1complete") == 1 && PlayerPrefs.GetInt("Puzzle2complete") == 1)
        {
            Destroy(gameObject);
        }
    }
}
