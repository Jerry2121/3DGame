using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzles : MonoBehaviour {
    public float timer;
    public Slider TimerSlide;
    public GameObject SlideCanvas;
    private bool complete;
    private bool enter = false;
    public bool CarKeys;
    // Use this for initialization
    void Start () {
        SlideCanvas.GetComponent<Canvas>().enabled = false;
        complete = false;

	}

    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Search");
        }
    }

    // Update is called once per frame
    void Update () {
       // TimerSlide.value = timer;
    }
    public void OnTriggerStay(Collider other)
    {

        if (Input.GetKey(KeyCode.E) && complete == false && CarKeys == false)
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
                Debug.Log("Nothing Was Found.");
                timer = 0;
                complete = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) && CarKeys == false || complete == true && CarKeys == false)
        {
            timer = 0;
            SlideCanvas.GetComponent<Canvas>().enabled = false;
        }

        if (Input.GetKey(KeyCode.E) && complete == false && CarKeys == true)
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
                Debug.Log("CarKeys Was found");
                timer = 0;
                complete = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E) && CarKeys == true || complete == true && CarKeys == true)
        {

            timer = 0;
            SlideCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
}
