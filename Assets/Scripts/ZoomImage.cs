using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomImage : MonoBehaviour
{
    public float zoomSpeed = 1.0f;  // Velocidad del zoom
    public float minScale = 0.5f;    // Escala mínima permitida
    public float maxScale = 3.0f;    // Escala máxima permitida

    // Update is called once per frame
    void Update()
    {
        // Calcular la nueva escala utilizando Mathf.PingPong para la animación automática
        float t = Mathf.PingPong(Time.time * zoomSpeed, 1.0f);
        float targetScale = Mathf.Lerp(minScale, maxScale, t);

        // Aplicar la escala
        transform.localScale = new Vector3(targetScale, targetScale, 1.0f);
    }
}
