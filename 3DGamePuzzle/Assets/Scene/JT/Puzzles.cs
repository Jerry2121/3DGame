using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzles : MonoBehaviour {
    public Slider TimerSlide;
    public GameObject SlideCanvas;
    public GameObject CarKeysIcon;
    public GameObject ObjectiveText;
    private bool complete;
    private bool enter = false;
    public bool CarKeys;
    private bool Nun = false;
    private bool yes = false;
    public float timer;
    private float time;
    private float time2;
    // Use this for initialization
    void Start () {
        SlideCanvas.GetComponent<Canvas>().enabled = false;
        complete = false;
        CarKeysIcon.GetComponent<RawImage>().enabled = false;
    }

    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 300, 30), "Hold 'E' or hold 'X' on a controller to search.");
            ObjectiveText.GetComponent<Text>().text = ("Objective: Search Drawers for any sort of tool that might help you escape.");
        }
        if (Nun)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 300, 60), "Nothing Was Found.");
        }
        if (yes)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 300, 60), "You found CarKeys!");
            ObjectiveText.GetComponent<Text>().text = ("Objective: Find the car. You might be able to use it to escape.");
        }
    }

    // Update is called once per frame
    void Update () {
        // TimerSlide.value = timer;
       if (Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.Joystick1Button2))
        {
            timer = 0;
            SlideCanvas.GetComponent<Canvas>().enabled = false;
        }
        time += Time.deltaTime;
        if (Nun && time <= 3)
        {
            Nun = false;
        }
        else
        {
            time = 0;
        }
        time2 += Time.deltaTime;
        if (yes && time2 <= 3)
        {
            yes = false;
        }
        else
        {
            time2 = 0;
        }
    }
    public void OnTriggerStay(Collider other)
    {

        if (Input.GetKey(KeyCode.E) && complete == false && CarKeys == false || Input.GetKey(KeyCode.Joystick1Button2) && complete == false && CarKeys == false)
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
                Nun = true;
                timer = 0;
                complete = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) && CarKeys == false || complete == true && CarKeys == false || Input.GetKeyUp(KeyCode.Joystick1Button2) && CarKeys == false)
        {
            timer = 0;
            SlideCanvas.GetComponent<Canvas>().enabled = false;
        }

        if (Input.GetKey(KeyCode.E) && complete == false && CarKeys == true || Input.GetKey(KeyCode.Joystick1Button2) && complete == false && CarKeys == true)
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
                yes = true;
                CarKeysIcon.GetComponent<RawImage>().enabled = true;
                AudioSource Audio = GetComponent<AudioSource>();
                Audio.Play();
                PlayerPrefs.SetInt("CarKeys", 1);
                timer = 0;
                complete = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) && CarKeys == true || complete == true && CarKeys == true || Input.GetKeyUp(KeyCode.Joystick1Button2) && CarKeys == true)
        {

            timer = 0;
            SlideCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
    //Activate the Main function when player is near the door
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = true;
        }
    }

    //Deactivate the Main function when player is go away from door
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = false;
        }
    }
}
