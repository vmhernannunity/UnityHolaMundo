using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColorEsfera : MonoBehaviour
{

    public GameObject prefabEsfera;
    int intContadorUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intContadorUpdate++;


        if (intContadorUpdate <= 1)
        {
            GameObject SegundaEsfera = Instantiate<GameObject>(prefabEsfera);
            //Crearemos colores aleatorios para el cubo... ************* AQUÍ
            Color c = new Color(Random.value, Random.value, Random.value);
            SegundaEsfera.GetComponent<MeshRenderer>().material.color = c;
        }
    }
}
