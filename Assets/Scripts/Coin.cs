using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] public int valor;
    [SerializeField] public ParticleSystem particulas;
    public float velocidadRotacion = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            // Instanciar partículas y destruir la moneda
            Instantiate(particulas, transform.position, Quaternion.identity);
            Destroy(gameObject);

            Score.instance.AgregarPuntos(valor);
        }
    }
}
