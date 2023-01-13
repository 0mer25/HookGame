using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    Camera cam;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] DistanceJoint2D distanceJoint2;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float hookForce;
    public bool hook;
    bool canHook;
    public float hookCd;
    public float remainToCd = -1f;
    
    private void Start() {
        hookCd = PlayerPrefs.GetFloat("hookCd");
        distanceJoint2.enabled = false;
        cam = Camera.main;
    }
    void Update() 
    {
        Vector3 mousePos = (Vector3)cam.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetKeyDown(KeyCode.Mouse0) && canHook)
        {
            lineRenderer.SetPosition(0 , mousePos);
            lineRenderer.SetPosition(1 , transform.position);
            distanceJoint2.connectedAnchor = mousePos;
            distanceJoint2.enabled = true;
            lineRenderer.enabled = true;
        }
        else if(Input.GetKeyUp(KeyCode.Mouse0) && canHook)
        {
            lineRenderer.enabled = false;
            remainToCd = hookCd;
            distanceJoint2.enabled = false;
        }

        if(distanceJoint2.enabled)
        {
            hook = true;
            lineRenderer.SetPosition(1 , transform.position);
            distanceJoint2.distance -= Time.deltaTime;
        }
        else
        {
            hook = false;
            canHook = false;
        }

        if(!hook)
        {
            remainToCd -= Time.deltaTime * 7f;
        }

        if(remainToCd < 0f)
        {
            canHook = true;
        }

    }
}
