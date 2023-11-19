using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinnBulletController : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Damageable"))
        {
            collision.gameObject.GetComponent<Health>().GetDamage(_damage);
            Destroy(gameObject);
            Debug.Log(collision.gameObject.name);
        }
    }
}
