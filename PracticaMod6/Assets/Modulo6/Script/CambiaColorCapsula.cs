using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColorCapsula : MonoBehaviour
{

    public GameObject prefabCapsula;
    int intContadorFixedUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        intContadorFixedUpdate++;

        if (intContadorFixedUpdate <= 4)
        {
            GameObject TerceraCapsula = Instantiate<GameObject>(prefabCapsula);
            //Crearemos colores aleatorios para el cubo... ************* AQUÍ
            Color c = new Color(Random.value, Random.value, Random.value);
            TerceraCapsula.GetComponent<MeshRenderer>().material.color = c;
        }
    }
}
