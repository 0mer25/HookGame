using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    Text txt;

    private void Start() {
        txt = GetComponent<Text>();
        txt.text = "HighScore : " + PlayerPrefs.GetInt("high").ToString();
    }
}
