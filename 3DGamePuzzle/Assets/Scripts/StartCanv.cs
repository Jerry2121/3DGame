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
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}