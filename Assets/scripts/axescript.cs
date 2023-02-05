using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axescript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject roots;
    private GameObject axe;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("axe"))
        {
            roots.SetActive(false);
            axe = GameObject.FindGameObjectWithTag("axe");
            axe.SetActive(false);
        }
        if (other.CompareTag("axe2"))
        {
            roots.SetActive(false);
            axe = GameObject.FindGameObjectWithTag("axe2");
            axe.SetActive(false);
        }
        if (other.CompareTag("axe3"))
        {
            roots.SetActive(false);
            axe = GameObject.FindGameObjectWithTag("axe3");
            axe.SetActive(false);
        }

    }



}
