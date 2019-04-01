using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour
{
    public float movHor;
    public float movVer;
    public float vel;
    private Rigidbody rig;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movHor = Input.GetAxis("Horizontal");
        movVer = Input.GetAxis("Vertical");

        //POR POSICION
        //transform.position = new Vector3(transform.position.x + movHor * vel *  Time.deltaTime, 
        //transform.position.y + movVer * vel*Time.deltaTime, transform.position.z);

        //POR FISICA
        Vector3 direccion = new Vector3(movHor, movVer, 0);
        rig.AddForce(direccion*force,ForceMode.Impulse);
    }
}
