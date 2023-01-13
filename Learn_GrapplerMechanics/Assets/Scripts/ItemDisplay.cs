using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemDisplay : MonoBehaviour
{
   public MarketItem marketItem;

   [SerializeField] Text desc;
   [SerializeField] Text nm;

   [SerializeField] Image art;
   [SerializeField] Text cost;

   private void Start() 
   {
        desc.text = marketItem.description;
        nm.text = marketItem.name;
        cost.text = marketItem.cost.ToString();
        art.sprite = marketItem.artwork;
   }

    
}
