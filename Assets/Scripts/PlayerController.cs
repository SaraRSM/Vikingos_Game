using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    float verInput;
    float horInput;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
        verInput = Input.GetAxis("Vertical");

        if (verInput == 0) 
        {
            Debug.Log("0");
            animator.SetInteger("Animacion",0);
        } else if (verInput > 0)
         {
            Debug.Log("0");
            animator.SetInteger("Animacion",1);
         }
    }
}
