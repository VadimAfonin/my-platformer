using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsPicController : MonoBehaviour
{
    [SerializeField] private GameObject[] _img;

    public void SetPicStars(int stars)
    {
        for (int i = 0; i < _img.Length; i++)
        {
            _img[i].SetActive(i == stars);
        }
    }
}
