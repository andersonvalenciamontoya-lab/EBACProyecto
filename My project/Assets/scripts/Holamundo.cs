using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola desde awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola desde start");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hola desde update");
    }
    private void FixedUpdate()
    {
       
        Debug.LogWarning("Hola desde FixedUpdate");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late");
        
    }
    private void OnEnable()
    {
        
        Debug.LogError("Hola desde OnEnable");
        
    }
    private void OnDisable()
    {
       
        Debug.LogWarning("Hola desde OnDisable");
    }
}
