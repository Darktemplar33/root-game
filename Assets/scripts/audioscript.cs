using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{
    [SerializeField] private LayerMask Floor;
    [SerializeField] private Transform Feet;
    public AudioSource footstepSound;

    // Update is called once per frame
    void Update()
    {

       
        


            if (Input.GetKey(KeyCode.W) && Physics.CheckSphere(Feet.position, 0.1f, Floor) || Input.GetKey(KeyCode.A) && Physics.CheckSphere(Feet.position, 0.1f, Floor) || Input.GetKey(KeyCode.S) && Physics.CheckSphere(Feet.position, 0.1f, Floor) || Input.GetKey(KeyCode.D) && Physics.CheckSphere(Feet.position, 0.1f, Floor))
            {
                footstepSound.enabled = true;

            }
            else
            {
                footstepSound.enabled = false;
            }
        
        
    }
}
