using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEffectorScript : MonoBehaviour
{
    [SerializeField] private GameObject _explosionCenter;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            _explosionCenter.SetActive(true);
            Destroy(_explosionCenter, 1);
        }
    }
}
