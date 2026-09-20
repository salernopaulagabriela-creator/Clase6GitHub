using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAPuntoSpawn1 : MonoBehaviour
{
    [SerializeField] Transform puntoSpawn;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position = puntoSpawn.position;
        }
    }
}
