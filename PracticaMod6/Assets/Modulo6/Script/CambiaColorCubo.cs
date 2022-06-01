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


    int intContadorAwake;
    // Start is called before the first frame update

    private void Awake()
    {

        /* Vamos a crear un GameObject (CubeObject) 
         * para instanciar nuestro prefab Usamos una funcion de unity 
         * "Instantiate<GameOgject>(para: 'el CubeObject')"*/

        GameObject primerCubo = Instantiate<GameObject>(PrefabCubo);
        // Pon nombre al cuble creado desde la funcion awake()
        primerCubo.name = "Cubo creado desde Awake() con prefab";
        // Imprime Nombre del cubo
        Debug.Log(primerCubo.name);

        //Crearemos colores aleatorios para el cubo... ************* AQUÍ
        Color c = new Color(Random.value, Random.value, Random.value);
        PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
    }



    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
}
