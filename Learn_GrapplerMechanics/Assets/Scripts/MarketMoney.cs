using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketMoney : MonoBehaviour
{
    private Text text;
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "x " + PlayerPrefs.GetInt("coin").ToString();
    }
}
