using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{
    Rigidbody2D rb;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(20f , 0f);
    }
    
    void Update()
    {
        
    }
}
