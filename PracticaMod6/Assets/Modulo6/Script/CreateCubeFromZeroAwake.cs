using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubeFromZeroAwake : MonoBehaviour
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
    private void Awake()
    {
        objToSpaw = new GameObject("Cubo creado desde Awake()");
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
        meshRendererMaterial.color = Color.red;
        objToSpaw.transform.position = Vector3.right;
        Debug.LogWarning("Este Cubo es creado desde Awake");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
