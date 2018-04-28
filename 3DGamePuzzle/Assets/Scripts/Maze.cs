using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Maze : MonoBehaviour {
    public GameObject HealthText;
    public GameObject Player;
    //public GameObject Go;
    public Vector3 startPos;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        HealthText.GetComponent<Text>().text = ("Lives: " + PlayerPrefs.GetInt("Health"));
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Maze") {

            transform.position = new Vector3(100, -100, 100);
        }
        if (other.gameObject.tag == "End")
        {
            SceneManager.LoadScene("Petty");
        }
    }
}
