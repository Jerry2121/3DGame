using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitches : MonoBehaviour {
    public bool LightSwitch1 = false;
    public bool LightSwitch2 = false;
    public bool LightSwitch3 = false;
    public bool LightSwitch4 = false;
    public bool puzzle = false;

    // Use this for initialization
    void Start () {
		
	}
    void ResetSwitch()
    {
        LightSwitch1 = false;
        LightSwitch2 = false;
        LightSwitch3 = false;
        LightSwitch4 = false;
        Debug.Log("Reset");
    }
   public void Set1() {
        LightSwitch1 = true;
    }
   public void Set2()
    {
        LightSwitch2 = true;
    }
   public void Set3()
    {
        LightSwitch3 = true;
    }
   public void Set4()
    {
        LightSwitch4 = true;
    }

    // Update is called once per frame
    void Update () {
        if (puzzle == false)
        {
            if (LightSwitch1 == true)
            {
                bool failcase = LightSwitch3 == true || LightSwitch4 == true;
                if (LightSwitch2 == false && failcase)
                {
                    ResetSwitch();
                }
                if (LightSwitch2 == true)
                {
                    failcase = LightSwitch4 == true;
                    if (LightSwitch3 == false && failcase)
                    {
                        ResetSwitch();
                    }
                    if (LightSwitch3 == true)
                    {
                        if (LightSwitch4 == true)
                        {
                            Debug.Log("GG");
                            puzzle = true;
                        }
                    }
                }
            }
        }



    }
}
