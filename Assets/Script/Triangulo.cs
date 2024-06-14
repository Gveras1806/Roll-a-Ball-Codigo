using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{
    Mesh m;
    MeshFilter mf;
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        mesh.name = "PyramidWithBase";

        // Definir los vértices de la pirámide
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(0, 1, 0),   // Vértice en la cúspide
            new Vector3(-0.5f, 0, 0.5f),  // Vértice 1 en la base (frontal izquierdo)
            new Vector3(0.5f, 0, 0.5f),   // Vértice 2 en la base (frontal derecho)
            new Vector3(0.5f, 0, -0.5f),  // Vértice 3 en la base (trasero derecho)
            new Vector3(-0.5f, 0, -0.5f)  // Vértice 4 en la base (trasero izquierdo)
        };

        // Definir los triángulos (caras) de la pirámide
        int[] triangles = new int[]
        {
            // Caras laterales
            0, 1, 2, // Frontal
            0, 2, 3, // Derecha
            0, 3, 4, // Trasera
            0, 4, 1, // Izquierda
              
            // Base (un cuadrado dividido en dos triángulos)
            1, 2, 3, // Triángulo frontal de la base
            1, 3, 4  // Triángulo trasero de la base
        };

        // Asignar los vértices y triángulos al mesh
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // Recalcular normales para el shading
        mesh.RecalculateNormals();

        // Asignar el mesh al componente MeshFilter
        GetComponent<MeshFilter>().mesh = mesh;
    

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
