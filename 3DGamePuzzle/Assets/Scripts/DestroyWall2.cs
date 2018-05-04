using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyWall2 : MonoBehaviour {
    public GameObject Player;
    public GameObject ObjectiveText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("Puzzle3complete") == 1 && PlayerPrefs.GetInt("Puzzle1complete") == 1 && PlayerPrefs.GetInt("Puzzle2complete") == 1)
        {
            ObjectiveText.GetComponent<Text>().text = ("Objective: What was that noise? It sounded like it came from downstairs?");
            AudioSource Audio = Player.GetComponent<AudioSource>();
            Audio.Play();
            Destroy(gameObject);
        }
    }
}
