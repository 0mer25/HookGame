using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(İnvisibility.instance.harmless == false)
        {
            if(other.gameObject.CompareTag("die"))
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
