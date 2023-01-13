using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    float speed;
    void Update()
    {
        speed = player.velocity.x;
        transform.position = new Vector2(transform.position.x + Time.deltaTime * speed , transform.position.y);

        if(RunGround.instance != null)
        {
            if(RunGround.instance.onGround)
            {
                player.velocity = new Vector2(3f , 0f);
            }
            else
            {
                player.velocity = new Vector2(player.velocity.x , player.velocity.y);
            }
        }
    }
}
