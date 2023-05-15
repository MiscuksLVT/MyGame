using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour {

    public Sprite Audioon;
    public Sprite Audiooff;
    public GameObject button;

    public AudioClip clip;
    public AudioSource audio;


    public void Start()
    {
        audio.PlayOneShot(clip);
    

    }

    public void OnOff()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            button.GetComponent<Image>().sprite = Audiooff;

        }
        else
        {
         
            AudioListener.volume = 1;
            button.GetComponent<Image>().sprite = Audioon;
        }
    }
}
