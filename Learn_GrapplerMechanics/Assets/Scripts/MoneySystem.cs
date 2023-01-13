using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("coin"))
        {
            PlayerPrefs.SetInt("coin" , PlayerPrefs.GetInt("coin") + 1);
            Destroy(other.gameObject);
        }
    }
}
