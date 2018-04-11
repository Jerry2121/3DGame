using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlesObjectives : MonoBehaviour {
    public GameObject ObjectiveText;
	// Use this for initialization
	void Start () {
        ObjectiveText.GetComponent<Text>().text = ("Objective: " + "Find out what is happening in this horrible place.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
