using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] GameObject[] rewards;
    [SerializeField] GameObject[] particles;
    Animator animator;
    GameObject obj;

    private void Start() {
        obj = rewards[Random.Range(0 , rewards.Length)];
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("hit"))
        {
            if(animator.GetCurrentAnimatorStateInfo(0).length >= 0)
            {
                Instantiate(obj , this.transform.position , this.transform.rotation);
                foreach(GameObject x in particles)
                {
                    Instantiate(x , transform.position , transform.rotation);
                }
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("fire"))
        {
            animator.SetBool("Hitted" , true);
        }
    }
}
