using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jinn : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _jinnTransform;

    private Animator anim;
    private bool youVisible;   


    private void Awake()
    {
        youVisible = false;
        anim = GetComponent<Animator>();
        _jinnTransform = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            if (_playerTransform.position.x > _jinnTransform.position.x)
            {
                _jinnTransform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                _jinnTransform.localScale = new Vector3(-1, 1, 1);
            }            
            youVisible = true;
            anim.SetBool("youVisible", true);
            StartCoroutine(ReturnShoot());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            youVisible = false;
            anim.SetBool("youVisible", false);
        }        
    }

    IEnumerator ReturnShoot()
    {
        while (youVisible && !Health.isDeath)
        {
            GetComponent<Shooter>().Shoot();
            anim.SetBool("youVisible", false);
            yield return new WaitForSecondsRealtime(2.0f);
        }            
    }
}
