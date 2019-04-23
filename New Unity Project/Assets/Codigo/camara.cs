using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    Vector3 posOriginal;
    const int cantPlanetas = 9;
    public GameObject[] posCamara;
    int contadorPosiciones = 0;
    float tiempoCamara;
    public float tiempoPorPlaneta = 3f;
    const float distanciaCamara = 20f;
    
    void Start()
    {
        posOriginal = transform.position;
    }

    void LateUpdate()
    {
        tiempoCamara += Time.deltaTime;
        if (tiempoCamara >= (contadorPosiciones + 1) * tiempoPorPlaneta)
        {
            contadorPosiciones++;

            if (contadorPosiciones == cantPlanetas)
            {
                tiempoCamara = 0f;
                contadorPosiciones = 0;
            }
        }

        switch(contadorPosiciones)
        {
            case 0:
                transform.LookAt(posCamara[contadorPosiciones].transform.position);
                transform.position = posOriginal;
                break;
            default:
                
                transform.position = new Vector3 (posCamara[contadorPosiciones].transform.position.x , posCamara[contadorPosiciones].transform.position.y-distanciaCamara, 
                                                    posCamara[contadorPosiciones].transform.position.z - distanciaCamara);
                transform.LookAt(posCamara[contadorPosiciones].transform.position);
                break;
        }
    }
}
