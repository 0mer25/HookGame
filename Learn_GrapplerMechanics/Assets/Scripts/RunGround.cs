using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGround : MonoBehaviour
{
    public static RunGround instance;

    public bool onGround;
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("runGround"))
        {
            onGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("runGround"))
        {
            onGround = false;
        }
    }
}
