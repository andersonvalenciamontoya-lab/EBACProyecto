using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboONandOFF : MonoBehaviour
{
    GameObject objtospawn;
    private static readonly Vector3[] value = {
        new Vector3(0, 0, 0),  //vertice0
        new Vector3(1, 0, 0),  //vertice1
        new Vector3(1, 1, 0),  //vertice2
        new Vector3(0, 1, 0),  //vertice3
        new Vector3(0, 1, 1),  //vertice4
        new Vector3(1, 1, 1),  //vertice5
        new Vector3(1, 0, 1),  //vertice6
        new Vector3(0, 0, 1),  //vertice7
    };
    Vector3[] vertices = value;

    int[] triangulos = {
    0, 2, 1,  //Cara 1
    0, 3, 2,
    2, 3, 4,  //Cara 2
    2, 4, 5,
    1, 2, 5,  //Cara 3
    1, 5, 6,
    0, 7, 4,  //Cara 4
    0, 4, 3,
    5, 4, 7,  //Cara 5
    5, 7, 6,
    0, 6, 7,  //Cara 6
    0, 1, 6
};
    private void OnEnable()
    {
        objtospawn = new GameObject("Mi cubo");
        objtospawn.AddComponent<MeshFilter>();
        var meshFilter = objtospawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objtospawn.AddComponent<BoxCollider>();
        var bocCollider = objtospawn.GetComponent<BoxCollider>();
        bocCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objtospawn.AddComponent<MeshRenderer>();
        var renderesmaterial = objtospawn.GetComponent<MeshRenderer>().material;
        renderesmaterial.color = Color.red;
        objtospawn.transform.position = Vector3.one;
        Debug.LogError("Cubo ON");

    }
    private void OnDisable()
    {
        objtospawn = new GameObject("Mi cubo");
        objtospawn.AddComponent<MeshFilter>();
        var meshFilter = objtospawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objtospawn.AddComponent<BoxCollider>();
        var bocCollider = objtospawn.GetComponent<BoxCollider>();
        bocCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objtospawn.AddComponent<MeshRenderer>();
        var renderesmaterial = objtospawn.GetComponent<MeshRenderer>().material;
        renderesmaterial.color = Color.blue;
        objtospawn.transform.position = Vector3.one;
        Debug.LogWarning("Cubo OFF");
    }
}
