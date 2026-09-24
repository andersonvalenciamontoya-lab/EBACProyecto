using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorAwake : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
