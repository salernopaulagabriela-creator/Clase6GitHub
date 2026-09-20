using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroMouse2 : MonoBehaviour
{
    float tiempoInicio;

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
        }
    }
}
