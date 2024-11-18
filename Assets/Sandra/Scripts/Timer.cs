using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] float totalTime;
    // [SerializeField] private Slider slider;
    // [SerializeField] private Image fill;
    // [SerializeField] private Gradient gradient;

    public bool pause;

    float elapsedTime;

    void Update()
    {
        if (!pause){
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else if (remainingTime < 0)
            {
                remainingTime = 0;
                // SceneManager.LoadScene("Bad Ending");
            }
            // int minutes = Mathf.FloorToInt(remainingTime / 60);
            // int seconds = Mathf.FloorToInt(remainingTime % 60);
            // int percentage = Mathf.FloorToInt(remainingTime / (totalTime / 100));
            // timerText.text = string.Format("{000}", percentage);
            // slider.value = remainingTime/totalTime;
            // Debug.Log(slider.value);
            // fill.color = gradient.Evaluate(Mathf.Min(1, 1-slider.value));

            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
