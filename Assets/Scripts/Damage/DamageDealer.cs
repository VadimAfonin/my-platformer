using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Damageable") && collision.gameObject.layer != 6)
        {
            collision.gameObject.GetComponent<Health>().GetDamage(_damage);
            Destroy(gameObject);
        }        
    }
}
