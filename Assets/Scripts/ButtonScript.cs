using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip �lick;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    public void Click() 
    {
        sound.PlayOneShot(�lick);
    }
}
