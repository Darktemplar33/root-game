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
    public GameObject floorRoots5;
    public GameObject floorRoots6;
    public GameObject floorRoots7;

    // Update is called once per frame
    void Update()
    {

        if (timerScript.currentTime <= 30 )
        {
            floorRoots.SetActive(true);
            

        }
        if (timerScript.currentTime <= 70)
        {
            floorRoots5.SetActive(true);


        }
        if (timerScript.currentTime <= 110)
        {
            floorRoots6.SetActive(true);


        }
        if (timerScript.currentTime <= 140)
        {
            floorRoots7.SetActive(true);


        }
        if (timerScript.currentTime <= 170 )
        {
            floorRoots4.SetActive(true);
            

        }
        if (timerScript.currentTime <= 200 )
        {
            floorRoots3.SetActive(true);
            

        }
        if (timerScript.currentTime <= 230 )
        {
            floorRoots2.SetActive(true);
            

        }
        if (timerScript.currentTime <= 260 )
        {
            floorRoots1.SetActive(true);
            

        }



    }
}
