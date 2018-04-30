using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarScript : MonoBehaviour {
    public Slider TimerSlide;
    public GameObject SlideCanvas;
    public GameObject CarKeysIcon;
    public GameObject ObjectiveText;
    private bool complete;
    private bool enter = false;
    private bool No = false;
    private bool yes = false;
    public float timer;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        
            if (enter)
            {
                GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 300, 30), "Hold 'E' or hold 'X' on a controller to search.");
            }
            if (No)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 300, 60), "The car is locked. Maybe there are some spair keys laying around?");
        }
            if (yes)
        {
            ObjectiveText.GetComponent<Text>().text = ("Objective: You found a piece of paper with a number on it. The numbers are 1234. What do they go to?");
        }
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && complete == false && PlayerPrefs.GetInt("CarKeys") == 1 || Input.GetKey(KeyCode.Joystick1Button2) && complete == false && PlayerPrefs.GetInt("CarKeys") == 1)
        {
            enter = false;
            SlideCanvas.GetComponent<Canvas>().enabled = true;
            timer += Time.deltaTime;
            float percent = timer / 5.0f;
            percent *= 100;
            int foo = Mathf.RoundToInt(percent);
            TimerSlide.value = foo;
            if (timer >= 5)
            {
                CarKeysIcon.GetComponent<RawImage>().enabled = false;
                PlayerPrefs.SetInt("Puzzle1Complete", 1);
                timer = 0;
                complete = true;
                yes = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) && PlayerPrefs.GetInt("CarKeys") == 1 || complete == true && PlayerPrefs.GetInt("CarKeys") == 1 || Input.GetKeyUp(KeyCode.Joystick1Button2) && PlayerPrefs.GetInt("CarKeys") == 1)
        {

            timer = 0;
            SlideCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
    //Activate the Main function when player is near the door
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && PlayerPrefs.GetInt("CarKeys") == 1)
        {
            enter = true;
        }
        if (collision.gameObject.tag == "Player" && PlayerPrefs.GetInt("CarKeys") == 0)
        {
            No = true;
        }
    }

    //Deactivate the Main function when player is go away from door
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && PlayerPrefs.GetInt("CarKeys") == 1)
        {
            enter = false;
        }
        if (collision.gameObject.tag == "Player" && PlayerPrefs.GetInt("CarKeys") == 0)
        {
            No = false;
        }
    }
}
