using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    /*
    llamo a Awake()
    Me da un error por que ya se creó una condicion de carrera con Start() de Componente1 
    ya que Awake() se ejecutó antes que start() y Start es quein da el nombre a miObjeto
    video 12:51 
     
    13:29 Soluición 1. cambiamos de orden las funciones en cada script
        a. pasamos lo que estaba en Awake a Start en componente2.cs
        b. creamos Awake en Componente 1 y pasamos lo que habia en Start() de componente 1
            a Awake de componente 1
    14:03 Listo se arreglo el problema, aun sigue saliendo el anriguo log de HolaMundo
        de Camera aun lo tengo cvivo por ahi. :)
      
    14:44 Agreguemos caos metiendo al juego a componente 3. 
        Ahi en Awake cambiaremos el nombre del objeto

    */

    private void Awake()
    {
        
    }



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Componente1.miObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
