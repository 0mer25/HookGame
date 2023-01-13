using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private Grappler grappler;
    BoxCollider2D col;
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Appear"))
        {
            animator.SetBool("Appeared" , true);
        }

        if(grappler.hook)
        {
            animator.SetBool("Hook" , true);
        }
        else
        {
            animator.SetBool("Hook" , false);
        }

        if(RunGround.instance.onGround)
        {
            animator.SetBool("OnGround" , true);
        }
        else 
        {
            animator.SetBool("OnGround" , false);
        }

        if(İnvisibility.instance.harmless)
        {
            col.isTrigger = true;
        }
        else
        {
            col.isTrigger = false;
        }
    }

    
}
