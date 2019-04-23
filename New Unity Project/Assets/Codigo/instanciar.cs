using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject prefab;
    Vector3 posBase;
    public GameObject sol;
    float distancia=15f;
    public Camara cam;

    // Start is called before the first frame update
    void Start()
    {
        if(cam.GetComponent<Camara>())
            cam.GetComponent<Camara>().posCamara[0] = sol;
        posBase = sol.transform.position + new Vector3(distancia, 0, 0);
        for(int i=0;i<8;i++)
        {
            GameObject go = Instantiate(prefab, posBase + new Vector3(i * distancia, 0, 0), Quaternion.identity);
            go.GetComponent<Planeta>().sol = sol;
            go.GetComponent<Planeta>().velOrbita = Random.Range(20,40);
            if (cam.GetComponent<Camara>())
                cam.GetComponent<Camara>().posCamara[i+1] = go;
        }
    }

}
