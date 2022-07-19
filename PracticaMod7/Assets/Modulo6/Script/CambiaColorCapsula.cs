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
        bln_Capsula_Color_N_capsula = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static bool bln_Cubo_Color_N_capsula; // para private void FixedUpdate() de este script
    public static bool bln_Esfera_Color_N_capsula; // para private void FixedUpdate() de este script
    public static bool bln_Capsula_Color_N_capsula; // para private void FixedUpdate() de este script


    // CambiaColorCubo cubo; //  ..  
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
            bln_Cubo_Color_N_capsula = CambiaColorCubo.bln_Cubo_Color;
            Debug.LogWarning("VALOR de variable BOOLEANA de GO 1 (Cubo) = " + bln_Cubo_Color_N_capsula + ", Valor OBTENIDO DESDE GO 1 (Cuno)");

            // Aqui obtengo el valor de la variale boleana del GO 2
            bln_Esfera_Color_N_capsula = CambiaColorEsfera.bln_Esfera_Color;
            Debug.LogWarning("VALOR de variable BOOLEANA de GO 2 (Esfera) = " + bln_Esfera_Color_N_capsula + ", Valor OBTENIDO DESDE GO 2 (Esfera)");

            // Ahora usare esos valores de las variables boolenas GO 1y2 para designar el color de la capsula

            bln_Capsula_Color_N_capsula = (bln_Cubo_Color_N_capsula == false && bln_Esfera_Color_N_capsula == true);

            if (bln_Capsula_Color_N_capsula)
            { 
                GameObject TerceraCapsula = Instantiate<GameObject>(prefabCapsula);
                //Crearemos colores aleatorios para el cubo... ************* AQUÍ

                //Color c = new Color(Random.value, Random.value, Random.value);
                Color c = new Color(255, 255, 255);
                TerceraCapsula.GetComponent<MeshRenderer>().material.color = c;
                Debug.LogWarning("El VALOR de variable BOOLEANA de GO 3 (Cápsula es true Operador AND) entonces la cápsula será BLANCA");
            }
        }
    }
}
