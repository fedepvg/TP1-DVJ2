using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeta : MonoBehaviour
{
    public string nombrePlaneta;
    public float radio;
    public GameObject sol;
    float angulo;
    public float velOrbita;
    public float velGiro;

    void orbitar()
    {
            transform.position = new Vector3(sol.transform.position.x + radio * Mathf.Cos(angulo + (velOrbita * Time.deltaTime)),
            sol.transform.position.y + radio * Mathf.Sin(angulo + (velOrbita * Time.deltaTime)),
            transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Planeta: " + nombrePlaneta);
    }

    // Update is called once per frame
    void Update()
    {
        radio = Vector3.Distance(sol.transform.position, transform.position);

        Vector3 targetDir =  transform.position - sol.transform.position;
        angulo = Mathf.Atan2(targetDir.y, targetDir.x);
        orbitar();
        transform.Rotate(0, 2, 0, Space.Self);
    }
}
