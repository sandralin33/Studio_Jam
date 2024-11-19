using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    AudioSource track;
    public static bool play = false;

    [SerializeField] AudioClip music;
    [SerializeField] AudioClip SFX;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        track = GetComponent<AudioSource>();
        track.clip = music;
        track.Play();
    }

    void Update()
    {
        // if (play)
        // {
        //     track.clip = SFX;
        //     track.Play();
        //     play = false;
        // }
    }
}
