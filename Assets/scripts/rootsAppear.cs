using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootsAppear : MonoBehaviour
{

    public timer timerScript;
    public GameObject floorRoots;
    public bool rootsActive =false;
    // Update is called once per frame
    void Update()
    {

        if (timerScript.currentTime <= 5 && !rootsActive)
        {
            floorRoots.SetActive(true);
            rootsActive = true;

        }


        
    }
}
