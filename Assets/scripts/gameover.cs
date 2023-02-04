using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{

	private bool gameEnded = false;
    public void WinLevel()
	{
        if (!gameEnded)
        {
			gameEnded = true;
			Debug.Log("you win");
			
        }
	
	}
	
	
	public void LoseLevel(){
	if(!gameEnded){
		Debug.Log("you lose");
		gameEnded = true;
		
	}
	
	}
	
	
}
