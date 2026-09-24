using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorUpdate : MonoBehaviour

{


    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
