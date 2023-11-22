using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float startTime;
    float currentTime;
    bool timerStarted = false;
    [SerializeField] TMP_Text timerText;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        timerText.text = currentTime.ToString();
        timerStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStarted)
        {
            currentTime -= Time.deltaTime;
            timerText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                timerStarted = false;
                currentTime = 0;
                timerText.text = "0";

            }
            timerText.text = "Time: " + currentTime.ToString("f1");

            if(currentTime == 0){
                //llamar a la escena de game over
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    
}
