using System.Collections;
usign UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    float currentTime;
    bool timerStarted = false;
    [SerializeField] TMP_Text timerText;

    float tiempoTotal;


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Destruir el objeto si ya existe
        }
    }

    public void Start()
    {
        InicializarTiempo(tiempoTotal);
    }

    public void AumentarTiempo(float tiempo)
    {
        currentTime += tiempo;
        timerText.text = currentTime.ToString();
    }

    public void InicializarTiempo(float tiempo)
    {
        tiempoTotal = tiempo;
        currentTime = tiempo;
        timerText.text = currentTime.ToString();
        timerStarted = true;
    }

    public void DetenerTiempo()
    {
        timerStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTime(currentTime);
        if (timerStarted)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                timerStarted = false;
                GameManager.instance.Resultado(false);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0){
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("Tiempo: {0:00}:{1:00}", minutes, seconds);
    }
    
}