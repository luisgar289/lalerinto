using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score: MonoBehaviour
{
    public static Score instance;

    [SerializeField] TMP_Text contadorText;
    int contadorActual = 0;

    private void Awake()
    {
        // Configurar el ScoreManager como singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Inicializar el contador con el valor inicial
        contadorActual = 0;
        ActualizarPuntuacion();
    }

    // Método para agregar puntos al contador
    public void AgregarPuntos(int puntos)
    {
        contadorActual += puntos;
        ActualizarPuntuacion();
    }

    // Método para actualizar el texto de puntuación
    private void ActualizarPuntuacion()
    {
        contadorText.text = "Puntuacion: " + contadorActual.ToString();
    }
}
