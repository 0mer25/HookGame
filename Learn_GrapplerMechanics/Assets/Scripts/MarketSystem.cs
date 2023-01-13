using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketSystem : MonoBehaviour
{
    ItemDisplay item;

    private void Start() {
        item = GetComponent<ItemDisplay>();
    }

    public void Buy()
    {
        if(PlayerPrefs.GetInt("coin") >= item.marketItem.cost)
        {
            item.marketItem.Do();
        }
    }
}
