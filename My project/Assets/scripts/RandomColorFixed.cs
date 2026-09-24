using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorFixed : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
