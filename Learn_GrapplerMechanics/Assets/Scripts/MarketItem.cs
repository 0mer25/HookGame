using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "Item")]
public class MarketItem : ScriptableObject
{
    public Sprite artwork;
    public new string name;
    public string description;
    
    public int cost;
    public itemType type;    

    public enum itemType
    {
        invisibility,
        decrease,
        doubleCoin
    };

    public void Do()
    {
        switch(type)
        {
            case itemType.invisibility:
                PlayerPrefs.SetInt("invisibility" , PlayerPrefs.GetInt("invisibility") + 1);
                PlayerPrefs.SetInt("coin" , PlayerPrefs.GetInt("coin") - cost);
                Debug.Log(cost);
                Debug.Log("buy i");
                break;
            
            case itemType.decrease:
                if(PlayerItems.instance.hookCd > 0)
                {
                    PlayerPrefs.SetFloat("hookCd" , PlayerPrefs.GetFloat("hookCd") - 0.5f);
                    PlayerPrefs.SetInt("coin" , PlayerPrefs.GetInt("coin") - cost);
                    Debug.Log("buy dec");
                    Debug.Log(cost);
                }
                else
                {
                    Debug.Log("maxx");
                }
                break;
            
            case itemType.doubleCoin:
                if(PlayerPrefs.GetInt("doubleCoin") == 0)
                {
                    PlayerPrefs.SetInt("doubleCoin" , 1);
                    PlayerPrefs.SetInt("coin" , PlayerPrefs.GetInt("coin") - cost);
                    Debug.Log(cost);
                    Debug.Log("buy dc");
                }
                else
                {
                    Debug.Log("u already bought this");
                }
                break;
        }
    }
}
