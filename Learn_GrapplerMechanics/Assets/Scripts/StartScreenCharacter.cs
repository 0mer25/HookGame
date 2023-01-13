using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenCharacter : MonoBehaviour
{
    Camera cam;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] DistanceJoint2D distanceJoint2;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float hookForce;
    public bool hook;
    void Start()
    {
        distanceJoint2.enabled = false;
        cam = Camera.main;
    }

    
    void Update()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        if(transform.position.y < 0.5f)
        {
            if(!hook)
            {
                Vector2 pos = new Vector2(transform.position.x + 4f , transform.position.y + 4f);
                lineRenderer.SetPosition(0 , pos);
                lineRenderer.SetPosition(1 , transform.position);
                distanceJoint2.connectedAnchor = pos;
                distanceJoint2.enabled = true;
                lineRenderer.enabled = true;
                hook = true;
            } 
        }
        
        yield return new WaitUntil(() => (transform.position.y > 2f));

        rb.AddForce(new Vector2(0.2f , 0.2f) , ForceMode2D.Force);

        distanceJoint2.enabled = false;
        lineRenderer.enabled = false;
        hook = false;
    }
}
