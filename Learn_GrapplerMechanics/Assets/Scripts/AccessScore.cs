using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessScore : MonoBehaviour
{
    Text txt;

    private void Awake() {
        if(PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("high"))
        {
            PlayerPrefs.SetInt("high" , PlayerPrefs.GetInt("score"));
        }
    }
    void Start()
    {
        txt = GetComponent<Text>();
        txt.text = "Score : " + PlayerPrefs.GetInt("score").ToString();

        
    }
    private void OnApplicationQuit() {
        PlayerPrefs.DeleteKey("score");
    }
}
