using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketBG : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(transform.position.x , transform.position.y + Time.deltaTime);
        if(transform.position.y > 15f)
        {
            transform.position = new Vector2(transform.position.x , transform.position.y - 36.74f);
        }
    }
}
