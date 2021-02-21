using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject button;
    public GameObject danger;
    
    public Animator anim;
    public Animator animwall;
    private bool Pressed;
    private bool Pressedwall;
 
    private bool Playernear = false; 


    // Start is called before the first frame update
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Playernear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Playernear = false;
        }
    }

    private void Update()
    {
         if (Playernear == true && Input.GetKeyDown(KeyCode.E) && !Pressed) 
        {
            anim.SetBool("Pressed", true);
           
            Debug.Log("Button has been pressed");
            Pressed = true;
            

        }
         if (Playernear == true && Input.GetKeyDown(KeyCode.E) && !Pressedwall)
        {
            animwall.SetBool("Pressedwall", true);
            Debug.Log("Button has been pressed");
            Pressedwall = true;
        }
    }




}
