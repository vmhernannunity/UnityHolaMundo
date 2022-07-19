using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColorCubo : MonoBehaviour
{


    /* PREFABS:
     * 
     * creamos GameObject que contendrá al prefab que acabamos de crear del cubo
     */
    public GameObject PrefabCubo;
    private GameObject primerCubo;

    public static bool bln_Cubo_Color; // para private void FixedUpdate() de este script

    int intContadorAwake;
    // Start is called before the first frame update


    private void Awake()
    {
        /* Vamos a crear un GameObject (CubeObject) 
         * para instanciar nuestro prefab Usamos una funcion de unity 
         * "Instantiate<GameOgject>(para: 'el CubeObject')"*/

        primerCubo = Instantiate<GameObject>(PrefabCubo);
        // Pon nombre al cuble creado desde la funcion awake()
        primerCubo.name = "GO 1, Cubo, creado desde Awake() con prefab";
        // Imprime Nombre del cubo
        Debug.Log(primerCubo.name);

        //Crearemos colores aleatorios para el cubo... 
        Color c = new Color(Random.value, Random.value, Random.value);
        PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
    }

    void Start()
    {
        bln_Cubo_Color = false;
    }


    // Update is called once per frame
    void Update()
    {

    }

    int contadorDeFixedUpdatesCubo = 0;

    private void FixedUpdate()
    {
        Color cambiaColor;

        contadorDeFixedUpdatesCubo = 1 + contadorDeFixedUpdatesCubo;

        if(contadorDeFixedUpdatesCubo <= 1)
        {
            if (bln_Cubo_Color == false)
            {
                Color c = new Color(0, 0, 0);
                cambiaColor = c;
                PrefabCubo.GetComponent<MeshRenderer>().material.color = cambiaColor;
                Debug.Log("Variable Boleana GO 1 'Cubo' False (pasará a ser true), entonces: CAMBIO GO 1 COLOR NEGRO");
                bln_Cubo_Color = true;
            }
            else 
            {
                Color c = new Color(255, 255, 255);
                cambiaColor = c;
                PrefabCubo.GetComponent<MeshRenderer>().material.color = cambiaColor;
                Debug.Log("Variable Boleana GO 1 'Cubo' true (pasará a ser false), entonces: CAMBIO GO 1 COLOR BLANCO");
                bln_Cubo_Color = false;
            }
        }
    }



}
