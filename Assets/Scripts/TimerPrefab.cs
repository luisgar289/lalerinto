using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPrefab : MonoBehaviour
{
    public float velocidadRotacion = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            Destroy(gameObject);
            Timer.instance.AumentarTiempo(10);
        }
    }
}
