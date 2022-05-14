using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Componente1.miObjeto.name = "NuevoNombreDeMiObjetoDesde_Componente3_Awake()";
    }

    // Vamos a cambiar el nombre de miObjeto por: "NuevoNombreDeMiObjetoDesde_Componente3_Awake()"

    /*  OJO IMPORTANTE OJO, OJO:
     *  
     *  En Awake() de componente 3 tu pones..
     -  Componente1.miObjeto.name = "NuevoNombreDeMiObjetoDesde_Componente3_Awake()"; (que esta en awake)
       y Al correrlo en Unity hay Error (14:57) , esto es por que las condiciones de carrera vuelven a competir
     *  
     *  UNA SOLUCION QUE NOTÉ es que podrias QUITAR las condiciones de carrera si pones 
     *  en START() de COMPONENTE 3:
     -  Componente1.miObjeto.name = "NuevoNombreDeMiObjetoDesde_Componente3_Awake()"; () que esta en awake
     *  
     *  Tiene exito esto porque EL FLUJO ES:
     *  
     *  Se crea miObjeto en Comonente 1
     *  Se llama a Awake de componente 1
     *  Se llama a Start() de componente 3
     *  Se llama a Start() de componente 2
     *  
     *  PERO, PERO no lo estamos asegurandoque sea asi, por ello ayq ue establecerlo
     *  a continuación se explica como:

     *  Viene la solución del profe:
     *  Cambiar el orden de ejecucion desde Unity en el Default Time (16:58)
     *  Abrimos execution order, agragamos tecla '+' abajo a ala derecha y ponemos componente 3
     *  este lo arrastramos  antes de default time.
     *  despues agragamos componente uno, lo arrastramos antes de componente 3
     *  y agregamos componente 2 y lo dejamos al final
     *  Arrastramos a compnente tres despes de default time y ya.
     *  
     *  Ahora vamos a VS y ponemos lo de awake de componente 1 en start de componente 1
     *  Ahora ya todo lo tenemos en start() de los 3 componentes
     *  Vamos  a Unity y corremos y funciona, él tiene otro erro veamos por qué.

     
     */
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
