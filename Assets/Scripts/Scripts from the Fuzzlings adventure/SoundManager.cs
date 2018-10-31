using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    AudioSource m_MyAudioSource;
    //Value from the slider, and it converts to volume level
    float m_MySliderValue;
    public float Volume = 0.1f;
    

    void Start()
    {
        //Initiate the Slider value to half way
        Volume = 0.5f;
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Play the AudioClip attached to the AudioSource on startup
        m_MyAudioSource.Play();

        m_MyAudioSource.volume = Volume;
    }

    void OnGUI()
    {
        //Create a horizontal Slider that controls volume levels. Its highest value is 1 and lowest is 0
        m_MySliderValue = GUI.HorizontalSlider(new Rect(25, 25, 200, 60), m_MySliderValue, 0.0F, 1.0F);
        //Makes the volume of the Audio match the Slider value
        m_MyAudioSource.volume = m_MySliderValue;
    }
}