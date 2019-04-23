using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    public GameObject sol;
    public float velOrbita;
    public float velGiro;

    void LateUpdate()
    {
        Orbitar();
        transform.Rotate(0, velGiro*Time.deltaTime, 0, Space.Self);
    }

    void Orbitar()
    {
        transform.RotateAround(sol.transform.position, Vector3.forward, (velOrbita * Time.deltaTime));
    }
}
