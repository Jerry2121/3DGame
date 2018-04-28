using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestThingy : MonoBehaviour {
    public bool Puzzle1Complete;
    public bool Puzzle2Complete;
    public bool Puzzle3Complete;
    public bool Reset;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt("Puzzle1complete") == 1)
        {
            Puzzle1Complete = true;
        }
        if (PlayerPrefs.GetInt("Puzzle2complete") == 1)
        {
            Puzzle2Complete = true;
        }
        if (PlayerPrefs.GetInt("Puzzle3complete") == 1)
        {
            Puzzle3Complete = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (Puzzle1Complete)
        {
            PlayerPrefs.SetInt("Puzzle1complete", 1);
        }
        if (Puzzle2Complete)
        {
            PlayerPrefs.SetInt("Puzzle2complete", 1);
        }
        if (Puzzle3Complete)
        {
            PlayerPrefs.SetInt("Puzzle3complete", 1);
        }
        if (Reset)
        {
            PlayerPrefs.SetInt("Puzzle1complete", 0);
            PlayerPrefs.SetInt("Puzzle2complete", 0);
            PlayerPrefs.SetInt("Puzzle3complete", 0);
            PlayerPrefs.SetInt("Health", 3);
        }
    }
}
