using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganaste : MonoBehaviour
{
    private int lastLevelIndex;

    void Start()
    {
        
    }

    // Función para avanzar a la pantalla con el siguiente índice
    public void AvanzarAPantallaSiguiente()
    {
        SceneManager.LoadScene(0);
    }
}
