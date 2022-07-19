using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColorEsfera : MonoBehaviour
{


    /* PREFABS:
 * 
 * creamos GameObject que contendrá al prefab que acabamos de crear del cubo
 */
    public GameObject prefabEsfera;
    private GameObject SegundaEsfera;

    public static bool bln_Esfera_Color; // para private void FixedUpdate() de este script

    int intContadorUpdate;
    // Start is called before the first frame update
    void Start()
    {
        bln_Esfera_Color = false;
    }

    // Update is called once per frame
    void Awake()
    {
        intContadorUpdate = 1 + intContadorUpdate;

        if (intContadorUpdate <= 1)
        {
            SegundaEsfera = Instantiate<GameObject>(prefabEsfera);
            //Crearemos colores aleatorios para el cubo... ************* AQUÍ.
            SegundaEsfera.name = "GO 2, Esfera, creada desde Udate() con prefab";
            // Imprime Nombre de la esfera
            Debug.Log(SegundaEsfera.name);

            Color c = new Color(Random.value, Random.value, Random.value);
            prefabEsfera.GetComponent<MeshRenderer>().material.color = c;
           
        }
    }


    int contadorDeFixedUpdatesEsfera = 0;
    private void FixedUpdate()
    {
        Color cambiaColor;
        contadorDeFixedUpdatesEsfera = 1 + contadorDeFixedUpdatesEsfera;

        if (contadorDeFixedUpdatesEsfera <= 1)
        {
            if (bln_Esfera_Color == false)
            {
                Color c = new Color(0, 0, 0);
                cambiaColor = c;
                prefabEsfera.GetComponent<MeshRenderer>().material.color = cambiaColor;
                Debug.Log("Variable Boleana GO 2 'Esfera' False (pasará a ser true), entonces: CAMBIO GO 2 COLOR NEGRO");
                bln_Esfera_Color = true;
            }
            else
            {
                Color c = new Color(255, 255, 255);
                cambiaColor = c;
                prefabEsfera.GetComponent<MeshRenderer>().material.color = cambiaColor;
                Debug.Log("Variable Boleana GO 2 'Esfera' true (pasará a ser false), entonces: CAMBIO GO 2 COLOR BLANCO");
                
                bln_Esfera_Color = false;
            }
        }
    }
}
