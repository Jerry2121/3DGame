using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//ASSUMPTION: all objects using this script will have unique names

public class BasicSave : MonoBehaviour
{
    public GameObject PauseMenu;
    void Start()
    {
        //Load our data using the stored playerpref
        //HUZZAH!
        Load(PlayerPrefs.GetString("Save"));
        //if we want to rest the playerPref, we do this:
        PlayerPrefs.SetString("Save", "");
    }


    public void Save(string state)
    {

        BinaryFormatter bf = new BinaryFormatter();
        //ASSUMPTION: all objects using this script will have unique names
        FileStream file = File.Open(Application.persistentDataPath
            + "/" + state + gameObject.name + ".dat", FileMode.OpenOrCreate);
        BasicSaveObj myData = new BasicSaveObj();
        myData.x = PlayerPrefs.GetFloat("PlayerPosX");
        myData.y = PlayerPrefs.GetFloat("PlayerPosY");
        myData.z = PlayerPrefs.GetFloat("PlayerPosZ");
        myData.health = PlayerPrefs.GetInt("Health");
        myData.puzzle1 = PlayerPrefs.GetInt("Puzzle1complete");
        myData.puzzle2 = PlayerPrefs.GetInt("Puzzle2complete");
        myData.puzzle3 = PlayerPrefs.GetInt("Puzzle3complete");
        myData.CarKeys = PlayerPrefs.GetInt("CarKeys");
        PauseMenu.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
        bf.Serialize(file, myData);
        file.Close();
    }

    public void Load(string state)
    {
        if (File.Exists(Application.persistentDataPath +
            "/" + state + gameObject.name + ".dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath +
            "/" + state + gameObject.name + ".dat", FileMode.Open);
            BasicSaveObj myData = (BasicSaveObj)bf.Deserialize(file);
            PlayerPrefs.SetFloat("PlayerPosX", myData.x);
            PlayerPrefs.SetFloat("PlayerPosY", myData.y);
            PlayerPrefs.SetFloat("PlayerPosZ", myData.z);
            PlayerPrefs.SetInt("Health", myData.health);
            PlayerPrefs.SetInt("Puzzle1complete", myData.puzzle1);
            PlayerPrefs.SetInt("Puzzle2complete", myData.puzzle2);
            PlayerPrefs.SetInt("Puzzle3complete", myData.puzzle3);
            PlayerPrefs.SetInt("CarKeys", myData.CarKeys);
            PauseMenu.GetComponent<Canvas>().enabled = false;
            Time.timeScale = 1;


            transform.position = new Vector3(myData.x, myData.y, myData.z);
            file.Close();
        }
    }



}


[System.Serializable]
public class BasicSaveObj
{
    public int health;
    public float x;
    public float y;
    public float z;
    public int puzzle1;
    public int puzzle2;
    public int puzzle3;
    public int CarKeys;


}
