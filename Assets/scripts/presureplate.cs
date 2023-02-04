using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presureplate : MonoBehaviour
{
    [SerializeField] GameObject door;
	[SerializeField] GameObject plate;
	
	private void OnTriggerEnter(Collider other)
	{
	door.transform.position = new Vector3(0,15,10);
	plate.transform.position = new Vector3(-1,1,-12);
	}
	
	
	
	void OnTriggerExit(Collider col)
	{
	
	door.transform.position = new Vector3 (0,6,10);
	plate.transform.position = new Vector3(-1,2,-12);
	
	}
	
	
	
}
