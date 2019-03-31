using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atmosfera : MonoBehaviour
{

    public GameObject planeta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = planeta.transform.position;
    }
}
