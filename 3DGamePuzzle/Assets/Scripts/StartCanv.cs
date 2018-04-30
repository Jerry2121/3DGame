using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StartCanv : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame()
    {
        SceneManager.LoadScene("House");
        PlayerPrefs.SetInt("Puzzle1complete", 0);
        PlayerPrefs.SetInt("Puzzle2complete", 0);
        PlayerPrefs.SetInt("Puzzle3complete", 0);
        PlayerPrefs.SetInt("Health", 3);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}