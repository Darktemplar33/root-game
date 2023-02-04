using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axescript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject roots;
    public GameObject axe;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("axe"))
        {
            roots.SetActive(false);
            axe.SetActive(false);
        }
       
    }



}
