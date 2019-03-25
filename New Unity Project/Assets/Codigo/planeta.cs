using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeta : MonoBehaviour
{
    public string nombrePlaneta;
    public float radio;
    public Vector3 pos;
    public GameObject sol;
    public float angulo;

    void orbitar()
    {
        transform.position = new Vector3(transform.position.x + radio * Mathf.Cos(angulo += Time.deltaTime),
            transform.position.y + radio * Mathf.Sin(angulo += Time.deltaTime),
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
        orbitar();
    }
}
