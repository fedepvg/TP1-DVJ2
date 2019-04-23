using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float movHor;
    public float movVer;
    public float vel;
    private Rigidbody rig;
    public float force;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movHor = Input.GetAxis("Horizontal");
        movVer = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(movHor, movVer, 0);
        rig.AddForce(direccion*force,ForceMode.Acceleration);
    }
}
