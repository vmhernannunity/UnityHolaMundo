using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holaMundo : MonoBehaviour
{


    /* 
     * Este Script ( HolaMundo.cs ) lo usar'e para hacer notas,
     no hay cambios que afecten el funcionamiento de Unity

     Aqui veremos lo que se conoce como condicion de carrera
     y es cuando se llmaam una funcion pero entes debe pasar otra
     si esto sucede habrá un erroy
    y se verá en Unity

    */



    void Start()
    {
        print("Algo Pasó");
        Debug.LogWarning("Algo salió medinamente mal");
        Debug.LogError("Algo salió muy mal");
        Debug.Log("Hola Mundo! Comenzó la partida!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HOLA DESDE Update EN HOLAMUNDO SCRIPT");
    }

     //   (20:05) En este momento vamos a usar este Script.
     //   
    private void FixedUpdate()
    {
        Debug.LogWarning("HOLA DE DESDE FixedUpdate CADA 50 FRAMES EN HOLAMUNDO SCRIPT");
    }

    private void LateUpdate()
    {
        Debug.Log("HOLA DESDE LateUpdate EN HOLAMUNDO SCRIPT");
    }

    private void OnEnable()
    {
        Debug.Log("EL OBJETO HA sido HABILIATDO EN HOLAMUNDO SCRIPT");
    }

    private void OnDisable()
    {
        Debug.Log("EL OBJETO HA sido INHABILIATDO EN HOLAMUNDO SCRIPT");
        
    }

}
