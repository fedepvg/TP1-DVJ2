using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    Vector3 posOriginal;
    const int cantPlanetas = 9;
    public GameObject[] posCamara=new GameObject[cantPlanetas];
    int contadorPosiciones = 0;
    float tiempoCamara;
    const float tiempoPorPos = 3f;
    const float distanciaCamara = 20f;

    // Start is called before the first frame update
    void Start()
    {
        posOriginal = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        tiempoCamara += Time.deltaTime;
        if (tiempoCamara >= (contadorPosiciones + 1) * tiempoPorPos)
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
