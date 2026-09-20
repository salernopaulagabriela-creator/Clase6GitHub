using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso3 : MonoBehaviour
{
    float tiempoInicio;
    Rigidbody rigidbodyMio;
    [SerializeField] float multiplicadorFuerza = 5f;

    void Awake()
    {
        rigidbodyMio = GetComponent<Rigidbody>();


    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tiempoInicio = Time.time;
        }

        if (Input.GetMouseButtonUp(0))
        {
            float tiempoTotal = Time.time - tiempoInicio;
            Debug.Log("Tiempo que mantuviste presionado el mouse: " + tiempoTotal);

            rigidbodyMio.AddForce(transform.forward * tiempoTotal * multiplicadorFuerza, ForceMode.Impulse);
        }
    }
}
