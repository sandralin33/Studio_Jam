using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource music; // music
    // public bool startMusic;
    public BeatScroller beat; // for scroll left
    public BeatScroller beatDown; // for scroll down
    // public Timer timer;
    public int currentScore;
    public int scorePerNote = 1;
    public Text scoreText;
    // public Text multiText; // multiplier not needed

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

        scoreText.text = "Enemy: 0";
    }

    // Update is called once per frame
    void Update()
    {   

    }

    public void NoteHit() // hit
    {
        Debug.Log("Hit");
        currentScore += scorePerNote;
        scoreText.text = "Enemies: " + currentScore;
    }

    public void NoteMissed() // miss
    {
        Debug.Log("Missed Note");
    }
}
