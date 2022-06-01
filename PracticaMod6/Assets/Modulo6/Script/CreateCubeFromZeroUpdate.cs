using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubeFromZeroUpdate : MonoBehaviour
{
    Vector3[] vertices = {
        new Vector3 (0, 0, 0),  //vertice0
        new Vector3 (1, 0, 0),  //vertice1
        new Vector3 (1, 1, 0),  //vertice2
        new Vector3 (0, 1, 0),  //vertice3
        new Vector3 (0, 1, 1),  //vertice4
        new Vector3 (1, 1, 1),  //vertice5
        new Vector3 (1, 0, 1),  //vertice6
        new Vector3 (0, 0, 1),  //vertice7
    };

    int[] triangulos = {
        0, 2, 1, //Cara1
        0, 3, 2,
        2, 3, 4, //Cara2
        2, 4, 5,
        1, 2, 5, //Cara3
        1, 5, 6,
        0, 7, 4, //Cara4
        0, 4, 3,
        5, 4, 7, //Cara5
        5, 7, 6,
        0, 6, 7, //Cara6
        0, 1, 6,
    };

    GameObject objToSpaw;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    int counter = 0;
    // Update is called once per frame
    void Update()
    {
        counter++;
        if(counter == 3) 
        { 
                    objToSpaw = new GameObject("Tercer Cubo creado desde Update()");
                    objToSpaw.AddComponent<MeshFilter>();
                    // "var" anuncia a una variable local que la distingue de las variables globales como "objToSpaw"
                    var meshFilter = objToSpaw.GetComponent<MeshFilter>().mesh;
                    meshFilter.Clear();
                    meshFilter.vertices = vertices;
                    meshFilter.triangles = triangulos;
                    meshFilter.Optimize();
                    meshFilter.RecalculateNormals();
                    objToSpaw.AddComponent<BoxCollider>();
                    var boxCollider = objToSpaw.GetComponent<BoxCollider>();
                    boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
                    objToSpaw.AddComponent<MeshRenderer>();
                    var meshRendererMaterial = objToSpaw.GetComponent<MeshRenderer>().material;
                    meshRendererMaterial.color = Color.green;
                    objToSpaw.transform.position = Vector3.left;
                    Debug.LogWarning("Tercer Cubo creado desde update");
         }



        if (counter == 2)
        {
            objToSpaw = new GameObject("Segundo Cubo creado desde Update()");
            objToSpaw.AddComponent<MeshFilter>();
            // "var" anuncia a una variable local que la distingue de las variables globales como "objToSpaw"
            var meshFilter = objToSpaw.GetComponent<MeshFilter>().mesh;
            meshFilter.Clear();
            meshFilter.vertices = vertices;
            meshFilter.triangles = triangulos;
            meshFilter.Optimize();
            meshFilter.RecalculateNormals();
            objToSpaw.AddComponent<BoxCollider>();
            var boxCollider = objToSpaw.GetComponent<BoxCollider>();
            boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
            objToSpaw.AddComponent<MeshRenderer>();
            var meshRendererMaterial = objToSpaw.GetComponent<MeshRenderer>().material;
            meshRendererMaterial.color = Color.white;
            objToSpaw.transform.position = Vector3.one;
            Debug.LogWarning("Segundo Cubo creado desde update");
        }

    }
}
