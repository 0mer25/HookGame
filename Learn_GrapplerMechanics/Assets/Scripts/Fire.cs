using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] GameObject obj;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(obj , this.transform.position , this.transform.rotation);
        }
    }
}
