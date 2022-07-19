using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColorGO5 : MonoBehaviour
{

    public GameObject prefabCubeGO5;
    int intContadorFixedUpdate;

    // Start is called before the first frame update
    void Start()
    {
        bln_GO5_Color_N_GO5 = false;
    }

    public static bool bln_Capsula_Color_N_GO5; // para private void FixedUpdate() de este script
    public static bool bln_Cilinder_Color_N_GO5; // para private void FixedUpdate() de este script
    public static bool bln_GO5_Color_N_GO5; // para private void FixedUpdate() de este script


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

            // Aqui obtengo el valor de la variale boleana del GO 3
            bln_Capsula_Color_N_GO5 = CambiaColorCapsula.bln_Capsula_Color_N_capsula;
            Debug.LogWarning("VALOR de variable BOOLEANA de GO 3 (Capsula) = " + bln_Capsula_Color_N_GO5 + ", Valor OBTENIDO DESDE GO 3 (Capsula)");

            // Aqui obtengo el valor de la variale boleana del GO 2
            bln_Cilinder_Color_N_GO5 = cambiaColorCilinder.bln_Cilinder_Color_N_cilinder;
            Debug.LogWarning("VALOR de variable BOOLEANA de GO 4 (Cilinder) = " + bln_Cilinder_Color_N_GO5 + ", Valor OBTENIDO DESDE GO 4 (Cilinder)");

            // Ahora usare esos valores de las variables boolenas GO 1y2 para designar el color de la capsula

            bln_GO5_Color_N_GO5 = (bln_Capsula_Color_N_GO5 == false || bln_Cilinder_Color_N_GO5 == true);

            if (bln_GO5_Color_N_GO5)
            {
                GameObject TerceraCapsula = Instantiate<GameObject>(prefabCubeGO5);
                //Crearemos colores aleatorios para el cubo... ************* AQUÍ

                //Color c = new Color(Random.value, Random.value, Random.value);
                Color c = new Color(255, 0, 0);
                TerceraCapsula.GetComponent<MeshRenderer>().material.color = c;
                Debug.LogWarning("El VALOR de variable BOOLEANA de GO 5 (BIG Cube, Operador OR) entonces el CUBO será ROJO");
            }
        }
    }

}
