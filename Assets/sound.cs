using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip a53, a54, a55, a56, a57, a61;
    public static sound instance;

    // Update is called once per frame

    private void Awake()
    {
        instance = this;
    }

    public void A53()
    {
        AudioSource.clip = a53;
        AudioSource.Play();
    }
    public void A54()
    {
        AudioSource.clip = a54;
        AudioSource.Play();
    }
    public void A55()
    {
        AudioSource.clip = a55;
        AudioSource.Play();
    }
    public void A56()
    {
        AudioSource.clip = a56;
        AudioSource.Play();
    }
    public void A57()
    {
        AudioSource.clip = a57;
        AudioSource.Play();
    }
    public void A61()
    {
        AudioSource.clip = a61;
        AudioSource.Play();
    }
}
