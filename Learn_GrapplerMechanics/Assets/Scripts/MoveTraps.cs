using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTraps : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(-speed , 0f);
    }
}
