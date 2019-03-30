using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    Vector3 posOriginal;
    const int cantPlanetas = 8;
    planeta[] planetas=new planeta[cantPlanetas];
    

    // Start is called before the first frame update
    void Start()
    {
        //planetas = new planeta[cantPlanetas];   
        posOriginal = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
