using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootsAppear : MonoBehaviour
{

    public timer timerScript;
    public GameObject floorRoots;
    public GameObject floorRoots1;
    public GameObject floorRoots2;
    public GameObject floorRoots3;
    public GameObject floorRoots4;
    
    // Update is called once per frame
    void Update()
    {

        if (timerScript.currentTime <= 60 )
        {
            floorRoots.SetActive(true);
            

        }
        if (timerScript.currentTime <= 120 )
        {
            floorRoots4.SetActive(true);
            

        }
        if (timerScript.currentTime <= 180 )
        {
            floorRoots3.SetActive(true);
            

        }
        if (timerScript.currentTime <= 240 )
        {
            floorRoots2.SetActive(true);
            

        }
        if (timerScript.currentTime <= 300 )
        {
            floorRoots1.SetActive(true);
            

        }



    }
}
