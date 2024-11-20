using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource music; // music
    public bool startMusic;
    // public Timer timer;
    public float currentScore;
    public int scorePerNote = 1;
    public Text scoreText;
    // public Text multiText; // multiplier not needed
    public float totalNotes;

    public static GameManager instance;

    void Awake()
    {
        instance = this; // only one GameManager
    }

    // Start is called before the first frame update
    void Start()
    {
        startMusic = true;
        music.Play();

        // scoreText.text = "Enemies Left: 0";
        totalNotes = FindObjectsOfType<NoteObject>().Length;
        currentScore = totalNotes;
    }

    // Update is called once per frame
    void Update()
    {   
        if (!music.isPlaying) {
            Debug.Log("FINISHED GAME");
            StartCoroutine(EndGame());
        }
    }

    public void NoteHit() // hit
    {
        Debug.Log("Hit");
        currentScore -= scorePerNote;
        scoreText.text = "Enemies Left: " + currentScore;
    }

    public void NoteMissed() // miss
    {
        Debug.Log("Missed Note");
        // SceneManager.LoadScene("Lose"); // lose
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Win"); // win
    }
}
