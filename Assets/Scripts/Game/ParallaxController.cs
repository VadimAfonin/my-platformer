using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    [SerializeField] private Transform[] _layers;
    [SerializeField] private float[] _coeffs;

    private int LayersCount;

    private void Start()
    {
        LayersCount = _layers.Length;
    }

    private void Update()
    {
        for (int i = 0; i < LayersCount; i++)
        {
            _layers[i].position = transform.position * _coeffs[i];
        }
    }
}
