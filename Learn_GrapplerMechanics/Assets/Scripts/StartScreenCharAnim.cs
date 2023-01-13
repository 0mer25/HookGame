using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenCharAnim : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private StartScreenCharacter startScreenCharacter;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Appear"))
        {
            animator.SetBool("Appeared" , true);
        }
        
        if(startScreenCharacter.hook)
        {
            animator.SetBool("Hook" , true);
        }
        else
        {
            animator.SetBool("Hook" , false);
        }
    }
}
