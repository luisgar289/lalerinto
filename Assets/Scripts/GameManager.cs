using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject victoriaPanel;
    public GameObject derrotaPanel;
    private bool victoria = false;

    void Start()
    {
        // Asegúrate de que ambas pantallas estén desactivadas al inicio
        victoriaPanel.SetActive(false);
        derrotaPanel.SetActive(false);
    }

    void Awake()
    {
        // Asegúrate de que solo haya una instancia de este objeto
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Resultado(bool victoria)
    {
        // Si el jugador ganó, muestra la pantalla de victoria
        if (victoria == true)
        {
            MostrarPantallaVictoria();
        }
        // Si el jugador perdió, muestra la pantalla de derrota
        else
        {
            MostrarPantallaDerrota();
        }
    }

    public void MostrarPantallaVictoria()
    {
        // Verifica si el panel de victoria no es nulo antes de intentar acceder a él
        if (victoriaPanel != null)
        {
            victoriaPanel.SetActive(true);
        }

        // Desactiva la pantalla de derrota (si existe)
        if (derrotaPanel != null)
        {
            derrotaPanel.SetActive(false);
        }
    }

    public void MostrarPantallaDerrota()
    {
        // Verifica si el panel de derrota no es nulo antes de intentar acceder a él
        if (derrotaPanel != null)
        {
            derrotaPanel.SetActive(true);
        }

        // Desactiva la pantalla de victoria (si existe)
        if (victoriaPanel != null)
        {
            victoriaPanel.SetActive(false);
        }
    }


    public void CargarSiguienteNivel()
    {
        // Obtén el índice de la escena actual
        int indiceActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indiceActual + 1);
    }

    public void IntentarDeNuevo()
    {
        // Obtén el nombre de la escena actual
        string nombreEscenaActual = SceneManager.GetActiveScene().name;

        // Reinicia la escena actual
        SceneManager.LoadScene(nombreEscenaActual);
    }

}
