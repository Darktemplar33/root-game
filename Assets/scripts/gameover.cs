using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gameover : MonoBehaviour
{

	private bool gameEnded = false;
	public GameObject loseUI;
	public GameObject winUI;

	public void WinLevel()
	{
        if (!gameEnded)
        {
			gameEnded = true;
			Debug.Log("you win");
			winUI.SetActive(true);
		}
	
	}
	
	
	public void LoseLevel(){
	if(!gameEnded)
	{
		Debug.Log("you lose");
		gameEnded = true;
		loseUI.SetActive(true);
		
	}
	
	}
	
	
}
