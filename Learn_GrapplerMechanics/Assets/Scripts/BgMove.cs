using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    [SerializeField] Transform obj;
    [SerializeField] Vector2 coordinates;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector2((transform.position.x - Time.deltaTime * 2) , transform.position.y);
        if((transform.position.x - obj.position.x) < coordinates.x)
        {
            transform.position = new Vector2(transform.position.x + coordinates.y , transform.position.y);
        }
    }
}
