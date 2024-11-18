using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource music; // music
    public bool startMusic;
    public BeatScroller beat;
    public BeatScroller beatDown;
    // public Timer timer;

    public static GameManager instance;

    void Awake()
    {
        instance = this; // only one GameManager
    }

    // Start is called before the first frame update
    void Start()
    {
        music.Play();
        beat.start = true;
        beatDown.start = true;
    }

    // Update is called once per frame
    void Update()
    {   

    }

    // hit
    public void NoteHit()
    {
        Debug.Log("Hit");
    }

    // miss
    public void NoteMissed()
    {
        Debug.Log("Missed Note");
    }
}
