using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TotalMonedas : MonoBehaviour
{
    public static TotalMonedas instance;

    [SerializeField] TMP_Text contadorText;

    [SerializeField] int defaultTime = 5;

    int totalActual = 0;

    float totalTimer = 10;


    private void Awake()
    {
        // Configurar el TotalMonedas como singleton
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
        ActualizarMonedas();
    }

    // Método para agregar monedas al contador
    public void AgregarMonedas(int monedas)
    {
        totalActual += monedas;
        totalTimer = defaultTime * totalActual;
        ActualizarMonedas();
        Timer.instance.InicializarTiempo(totalTimer);
    }

    // Método para restar monedas del contador
    public void RestarMonedas(int moneda)
    {
        totalActual -= moneda;
        if (totalActual == 0)
        {
            Timer.instance.DetenerTiempo();
            GameManager.instance.Resultado(true);
        }
        else
        {
            ActualizarMonedas();
        }
    }

    // Método para actualizar el texto de monedas
    private void ActualizarMonedas()
    {
        contadorText.text = "Monedas Restantes: " + totalActual.ToString();
    }
}