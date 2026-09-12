using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("NICE");
        Debug.LogError("OOOOO NOOO");
        Debug.LogWarning("REVISATE");
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
