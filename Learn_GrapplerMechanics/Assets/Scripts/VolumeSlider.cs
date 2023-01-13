using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    Slider slider;

    private void Start() {
        slider = GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("volumeSlider");
    }
    


    private void OnDestroy() {
        if(!PlayerPrefs.HasKey("volumeSlider"))
        {
            PlayerPrefs.SetFloat("volumeSlider" , slider.value);
        }
        else
            PlayerPrefs.SetFloat("volumeSlider" , slider.value);
    }
}
