using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        float x = Random.Range(-1f , 1f);
        float y = Random.Range(-1f , 1f);
        var dir = new Vector2(x , y);
        rb.AddForce(dir.normalized * 10f , ForceMode2D.Force);
        rb.AddTorque(100f , ForceMode2D.Force);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("destroyObjects"))
        {
            Destroy(this.gameObject);
        }
    }
}
