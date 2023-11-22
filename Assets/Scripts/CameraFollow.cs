using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newXPosition = player.transform.position.x + offset.x;
        float newZPosition = player.transform.position.z + offset.z;
        transform.position = new Vector3(newXPosition, transform.position.y, newZPosition);
    }
}
