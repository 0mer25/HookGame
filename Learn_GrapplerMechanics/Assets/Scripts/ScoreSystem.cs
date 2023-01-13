using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    int score;
    float x;
    [SerializeField] Text txt;
    void Start()
    {
        x = 0;
        score = 0;
    }

    
    void Update()
    {
        x += Time.deltaTime;
        score += (int)x;
        txt.text = score.ToString();
        //PlayerPrefs.SetInt("score" , score);
    }

    private void OnDisable() {
        PlayerPrefs.SetInt("score" , score);
    }
}
