using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Safe : MonoBehaviour {
    public bool one = false;
    public bool two = false;
    public bool three = false;
    public bool four = false;
    public bool five = false;
    public bool six = false;
    public bool seven = false;
    public bool eight = false;
    public bool nine = false;
    public bool zero = false;
    public GameObject Player;
    public GameObject ObjectiveText;
    public float timer;
    public bool complete;
    public bool yes;


    private void Start()
    {
        complete = false;
    }

    void ONE()
    {
        one = true;
    }
    void TWO()
    {
        two = true;
    }
    void THREE()
    {
        three = true;
    }
    void FOUR()
    {
        four = true;
    }
    void FIVE()
    {
        five = true;
    }
    void SIX()
    {
        six = true;
    }
    void SEVEN()
    {
        seven = true;
    }
    void EIGHT()
    {
        eight = true;
    }
    void NINE()
    {
        nine = true;
    }
    void ZERO()
    {
        zero = true;
        Debug.Log("0");
    }
    public void Update()
    {
        if (one == true && eight == true && four == true)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "one")
        {
            ONE();
        }
        if (collision.gameObject.name == "two")
        {
            TWO();
        }
        if (collision.gameObject.name == "three")
        {
            THREE();
        }
        if (collision.gameObject.name == "four")
        {
            FOUR();
        }
        if (collision.gameObject.name == "five")
        {
            FIVE();
        }
        if (collision.gameObject.name == "six")
        {
            SIX();
        }
        if (collision.gameObject.name == "seven")
        {
            SEVEN();
        }
        if (collision.gameObject.name == "eight")
        {
            EIGHT();
        }
        if (collision.gameObject.name == "nine")
        {
            NINE();
        }
        if (collision.gameObject.name == "zero")
        {
            ZERO();
        }
        if (one == true && eight == true && four == true) {
            PlayerPrefs.SetInt("Puzzle3complete", 1);
            ObjectiveText.GetComponent<Text>().text = ("Objective: You found a piece of paper with a riddle on it. The riddle says. The colors of 50 states and the odd one out.");
            timer += Time.deltaTime;
            if (timer <= 2.009 && !complete)
            {
                AudioSource Audio = Player.GetComponent<AudioSource>();
                Audio.Play();
                complete = true;
            }
        }
    }
}
