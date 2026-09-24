using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubespawn : MonoBehaviour

{
    public GameObject prefabCubo;
    public List<GameObject> Listadecubos;
    public float factordeEscala;
    public int NumdeCubos;

    // Start is called before the first frame update
    void Start()
    {
        Listadecubos = new List<GameObject>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        NumdeCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "cubo numero" + NumdeCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        Listadecubos.Add(tempGameObject);
        List<GameObject> Eliminar = new List<GameObject>();
        foreach (GameObject go in Listadecubos) 
        {
            float scale = go.transform.localScale.x;
            scale *= factordeEscala;
            go.transform.localScale = Vector3.one * scale;

            if (scale<= 0.1)
            {
                Eliminar.Add(go);
            }

        }
        foreach (GameObject go in Eliminar)
        {
            Listadecubos.Remove(go);
            Destroy(go);
        }
    }
}
