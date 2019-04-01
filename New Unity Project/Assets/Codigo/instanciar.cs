using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciar : MonoBehaviour
{
    public GameObject prefab;
    Vector3 posBase;
    public GameObject sol;
    float distancia=15f;
    public camara cam;

    // Start is called before the first frame update
    void Start()
    {
        cam.GetComponent<camara>().posCamara[0] = sol;
        posBase = sol.transform.position + new Vector3(distancia, 0, 0);
        for(int i=0;i<9;i++)
        {
            GameObject go = Instantiate(prefab, posBase + new Vector3(i * distancia, 0, 0), Quaternion.identity);
            go.GetComponent<planeta>().sol = sol;
            go.GetComponent<planeta>().velOrbita = Random.Range(20,40);
            cam.GetComponent<camara>().posCamara[i+1] = go;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
