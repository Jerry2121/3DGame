using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//ASSUMPTION: all objects using this script will have unique names

public class BasicSave : MonoBehaviour
{

    // Use this for initialization
    int hp = 10;

    void Start()
    {
        //Load our data using the stored playerpref
        //HUZZAH!
        Load(PlayerPrefs.GetString("Save"));
        //if we want to rest the playerPref, we do this:
        PlayerPrefs.SetString("Save", "");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Save("state1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Save("state2");
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Load("state1");
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Load("state2");
        }

    }
    public void Save(string state)
    {

        BinaryFormatter bf = new BinaryFormatter();
        //ASSUMPTION: all objects using this script will have unique names
        FileStream file = File.Open(Application.persistentDataPath
            + "/" + state + gameObject.name + ".dat", FileMode.OpenOrCreate);
        BasicSaveObj myData = new BasicSaveObj();
        myData.hp = hp;
        myData.x = transform.position.x;
        myData.y = transform.position.y;
        myData.z = transform.position.z;
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
            hp = myData.hp;
            transform.position = new Vector3(myData.x, myData.y, myData.z);
            file.Close();
        }
    }



}


[System.Serializable]
public class BasicSaveObj
{
    public int hp;
    public float x;
    public float y;
    public float z;
}
