using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AjusteVolumen : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    // Update is called once per frame
    public void SetVolume(float value)
    {
        audioSource.volume = value;
    }
}
