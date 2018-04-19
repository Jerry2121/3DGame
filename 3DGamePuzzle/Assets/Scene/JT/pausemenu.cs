using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {
    bool paused = false;
    public GameObject Canvas;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            paused = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Canvas.GetComponent<Canvas>().enabled = true;
            Cursor.visible = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            Resume();
        }
        /*if (paused)
        {
            Time.timeScale = 0;
            Canvas.GetComponent<Canvas>().enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (paused == false)
        {
            Time.timeScale = 1;
            Canvas.GetComponent<Canvas>().enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }*/
    }
    public void Resume()
    {
        Debug.Log("foo");
        Canvas.GetComponent<Canvas>().enabled = false;
        paused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}