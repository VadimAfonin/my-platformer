using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour
{
    [SerializeField] private float _damage;

    private Animator _anim;
    private SpriteRenderer rend;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            rend.flipX = true;
            _anim.SetBool("youVisible", true);
            collision.gameObject.GetComponent<Health>().GetDamage(_damage);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        rend.flipX = false;
        _anim.SetBool("youVisible", false);
    }
}
