using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBall : MonoBehaviour
{
    DistanceJoint2D dst;
    void Start()
    {
        dst = GetComponent<DistanceJoint2D>();
    }

    
    void Update()
    {
        var dir = new Vector2((dst.connectedAnchor.x - dst.anchor.x) , (dst.connectedAnchor.y - dst.anchor.y));
        float angel = Vector2.Angle(dir.normalized , transform.up);
        
        if(true)
        {
            transform.Rotate(transform.forward , angel);
        }
    }
}
