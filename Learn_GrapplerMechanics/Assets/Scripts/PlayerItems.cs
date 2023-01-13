using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public static PlayerItems instance;

    public int invisibility = 0;
    public int doubleCoin = 0;
    public float hookCd = 4f;

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
        instance = this;
    }
    private void Start() {
        if(PlayerPrefs.HasKey("invisibility") ==  false)
        {
            PlayerPrefs.SetInt("invisibility" , 0);
        }

        if(PlayerPrefs.HasKey("doubleCoin") ==  false)
        {
            PlayerPrefs.SetInt("doubleCoin" , 0);
        }

        if(PlayerPrefs.HasKey("hookCd") ==  false)
        {
            PlayerPrefs.SetFloat("hookCd" , 4f);
        }
    }
    
    private void Update() {
        invisibility = PlayerPrefs.GetInt("invisibility");
        doubleCoin = PlayerPrefs.GetInt("doubleCoin");
        hookCd = PlayerPrefs.GetFloat("hookCd");
    }
}
