using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("click");
        }

    }

    void ONE()
    {
        one = true;
        Debug.Log("1");
    }
    void TWO()
    {
        two = true;
        Debug.Log("2");
    }
    void THREE()
    {
        three = true;
        Debug.Log("3");
    }
    void FOUR()
    {
        four = true;
        Debug.Log("4");
    }
    void FIVE()
    {
        five = true;
        Debug.Log("5");
    }
    void SIX()
    {
        six = true;
        Debug.Log("6");
    }
    void SEVEN()
    {
        seven = true;
        Debug.Log("7");
    }
    void EIGHT()
    {
        eight = true;
        Debug.Log("8");
    }
    void NINE()
    {
        nine = true;
        Debug.Log("9");
    }
    void ZERO()
    {
        zero = true;
        Debug.Log("0");
    }
    void OnTriggerStay(Collider collision)
    {
        //Debug.Log(collision.gameObject);
        if (collision.gameObject.name == "one" && Input.GetKeyDown(KeyCode.E))
        {
            ONE();
        }
        if (collision.gameObject.name == "two" && Input.GetKeyDown(KeyCode.E))
        {
            TWO();
        }
        if (collision.gameObject.name == "three" && Input.GetKeyDown(KeyCode.E))
        {
            THREE();
        }
        if (collision.gameObject.name == "four" && Input.GetKeyDown(KeyCode.E))
        {
            FOUR();
        }
        if (collision.gameObject.name == "five" && Input.GetKeyDown(KeyCode.E))
        {
            FIVE();
        }
        if (collision.gameObject.name == "six" && Input.GetKeyDown(KeyCode.E))
        {
            SIX();
        }
        if (collision.gameObject.name == "seven" && Input.GetKeyDown(KeyCode.E))
        {
            SEVEN();
        }
        if (collision.gameObject.name == "eight" && Input.GetKeyDown(KeyCode.E))
        {
            EIGHT();
        }
        if (collision.gameObject.name == "nine" && Input.GetKeyDown(KeyCode.E))
        {
            NINE();
        }
        if (collision.gameObject.name == "zero" && Input.GetKeyDown(KeyCode.E))
        {
            ZERO();
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "one" && Input.GetKeyDown(KeyCode.E))
        {
            ONE();
        }
        if (collision.gameObject.name == "two" && Input.GetKeyDown(KeyCode.E))
        {
            TWO();
        }
        if (collision.gameObject.name == "three" && Input.GetKeyDown(KeyCode.E))
        {
            THREE();
        }
        if (collision.gameObject.name == "four" && Input.GetKeyDown(KeyCode.E))
        {
            FOUR();
        }
        if (collision.gameObject.name == "five" && Input.GetKeyDown(KeyCode.E))
        {
            FIVE();
        }
        if (collision.gameObject.name == "six" && Input.GetKeyDown(KeyCode.E))
        {
            SIX();
        }
        if (collision.gameObject.name == "seven" && Input.GetKeyDown(KeyCode.E))
        {
            SEVEN();
        }
        if (collision.gameObject.name == "eight" && Input.GetKeyDown(KeyCode.E))
        {
            EIGHT();
        }
        if (collision.gameObject.name == "nine" && Input.GetKeyDown(KeyCode.E))
        {
            NINE();
        }
        if (collision.gameObject.name == "zero" && Input.GetKeyDown(KeyCode.E))
        {
            ZERO();
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "one" && Input.GetKeyDown(KeyCode.E))
        {
            ONE();
        }
        if (collision.gameObject.name == "two" && Input.GetKeyDown(KeyCode.E))
        {
            TWO();
        }
        if (collision.gameObject.name == "three" && Input.GetKeyDown(KeyCode.E))
        {
            THREE();
        }
        if (collision.gameObject.name == "four" && Input.GetKeyDown(KeyCode.E))
        {
            FOUR();
        }
        if (collision.gameObject.name == "five" && Input.GetKeyDown(KeyCode.E))
        {
            FIVE();
        }
        if (collision.gameObject.name == "six" && Input.GetKeyDown(KeyCode.E))
        {
            SIX();
        }
        if (collision.gameObject.name == "seven" && Input.GetKeyDown(KeyCode.E))
        {
            SEVEN();
        }
        if (collision.gameObject.name == "eight" && Input.GetKeyDown(KeyCode.E))
        {
            EIGHT();
        }
        if (collision.gameObject.name == "nine" && Input.GetKeyDown(KeyCode.E))
        {
            NINE();
        }
        if (collision.gameObject.name == "zero" && Input.GetKeyDown(KeyCode.E))
        {
            ZERO();
        }
    }

}
