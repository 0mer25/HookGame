using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İnvisibility : MonoBehaviour
{
    public static İnvisibility instance;
    float timer;
    public float remainTime = -1f;
    float cd = 10f;
    public float remainCd = -1f;
    public bool harmless = false;
    void Start()
    {
        instance = this;
        timer = 4f;
    }

    void Update()
    {
        // Check the key
        if((remainCd <= 0) && Input.GetKeyDown(KeyCode.R) && (PlayerPrefs.GetInt("invisibility") > 0))
        {
            harmless = true;
            PlayerPrefs.SetInt("invisibility" , PlayerPrefs.GetInt("invisibility") - 1);
            remainCd = cd;
        }

        // If skill is active
        if(harmless)
        {
            if(remainTime > 0)
            {
                remainTime -= Time.deltaTime;
            }
            else
            {
                harmless = false;
                remainTime = timer;
            }
        }
        // If skill is on cd
        else
        {
            if(remainCd > 0)
            {
                remainCd -= Time.deltaTime;
            }
        }
    }
}
