using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallinglose : MonoBehaviour
{
    // Start is called before the first frame update
    public gameover GameOverScript;

    // Update is called once per frame
    void Update()
    {
		if(transform.position.y < -2.0f){
		GameOverScript.LoseLevel();
		}
        
    }
}
