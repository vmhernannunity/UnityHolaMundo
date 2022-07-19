using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiaColorCilinder : MonoBehaviour
{

    /* PREFABS:
 * 
 * creamos GameObject que contendrá al prefab que acabamos de crear del cubo
 */
    public GameObject prefabCilinder;
    int intContadorFixedUpdate;


    private void Awake()
    {
 ////////////       /* Vamos a crear un GameObject (CubeObject) 
 ////////////* para instanciar nuestro prefab Usamos una funcion de unity 
 ////////////* "Instantiate<GameOgject>(para: 'el CubeObject')"*/

 ////////////       GameObject primerCilinder = Instantiate<GameObject>(prefabCilinder);
 ////////////       // Pon nombre al cuble creado desde la funcion awake()
 ////////////       primerCilinder.name = "Cilindro creado desde Awake() con prefab 1 vez";
 ////////////       // Imprime Nombre del cubo
 ////////////       // Debug.Log(primerCilinder.name);

 ////////////       //Crearemos colores aleatorios para el cubo... ************* AQUÍ
 ////////////       Color c = new Color(Random.value, Random.value, Random.value);
 ////////////       primerCilinder.GetComponent<MeshRenderer>().material.color = c;
    }


    // Start is called before the first frame update
    void Start()
    {
        bln_Cilinder_Color_N_cilinder = false;
    }

    public static bool bln_Cubo_Color_N_cilinder; // para private void FixedUpdate() de este script
    public static bool bln_Esfera_Color_N_cilinder; // para private void FixedUpdate() de este script
    public static bool bln_Cilinder_Color_N_cilinder; // para private void FixedUpdate() de este script


    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        intContadorFixedUpdate++;

        if (intContadorFixedUpdate <= 1)
        {

            // Seguna la actividad debo hacer que el balor de la variable booleana de este script
            // dependa de las otras 2 de los GO1y2. entonces los obtendré 
            // despues haré el operador && para generarla y asignar un color 
            // a la nueva capsula. 
            //ENTONCES:

            // Aqui obtengo el valor de la variale boleana del GO 1
            bln_Cubo_Color_N_cilinder = CambiaColorCubo.bln_Cubo_Color;
            Debug.LogWarning("VALOR de variable BOOLEANA de GO 1 (Cubo) = " + bln_Cubo_Color_N_cilinder + ", Valor OBTENIDO DESDE GO 1 (Cubo)");

            // Aqui obtengo el valor de la variale boleana del GO 2
            bln_Esfera_Color_N_cilinder = CambiaColorEsfera.bln_Esfera_Color;
            Debug.LogWarning("VALOR de variable BOOLEANA de GO 2 (Esfera) = " + bln_Esfera_Color_N_cilinder + ", Valor OBTENIDO DESDE GO 2 (Esfera)");

            // Ahora usare esos valores de las variables boolenas GO 1y2 para designar el color de la capsula

            bln_Cilinder_Color_N_cilinder = (bln_Cubo_Color_N_cilinder == false || bln_Esfera_Color_N_cilinder == true);

            if (bln_Cilinder_Color_N_cilinder)
            {
                GameObject TerceraCapsula = Instantiate<GameObject>(prefabCilinder);
                //Crearemos colores aleatorios para el cubo... ************* AQUÍ

                //Color c = new Color(Random.value, Random.value, Random.value);
                Color c = new Color(255, 255, 255);
                TerceraCapsula.GetComponent<MeshRenderer>().material.color = c;
                Debug.LogWarning("El VALOR de variable BOOLEANA de GO 4 (Cilinder es true operador OR) entonces el Cilindro será BlANCO");
            }
        }
    }
}
