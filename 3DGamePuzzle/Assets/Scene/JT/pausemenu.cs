using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {
    bool paused = false;
    public GameObject Canvas;
    public GameObject ResumeButton;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && paused == false || Input.GetKey(KeyCode.Joystick1Button6) || Input.GetKey(KeyCode.Joystick1Button7))
        {
            paused = true;
            Time.timeScale = 0;
            Canvas.GetComponent<Canvas>().enabled = true;
            UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(ResumeButton);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true || Input.GetKey(KeyCode.Joystick1Button6) || Input.GetKey(KeyCode.Joystick1Button7))
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
        Canvas.GetComponent<Canvas>().enabled = false;
        paused = false;
        Time.timeScale = 1;
        UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}