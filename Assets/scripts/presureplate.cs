using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presureplate : MonoBehaviour
{
    [SerializeField] GameObject door;
	[SerializeField] GameObject plate;
	
	private void OnTriggerEnter(Collider other)
	{
	door.transform.position = new Vector3(-1f, 10f, 5f);
	plate.transform.position = new Vector3(-15.1969995f, 2.65500002f, 7.90600014f);
	}
	
	
	
	void OnTriggerExit(Collider col)
	{
	
	door.transform.position = new Vector3 (-1f, -1f, 5f);
	plate.transform.position = new Vector3(-15.1969995f, 2.85500002f, 7.90600014f);
	
	}
	
	
	
}
