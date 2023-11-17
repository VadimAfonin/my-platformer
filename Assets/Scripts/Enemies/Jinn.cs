using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jinn : MonoBehaviour
{
    private Animator anim;
    private bool youVisible;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
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
            GetComponent<Shooter>().Shoot(-1);
            anim.SetBool("youVisible", false);
            yield return new WaitForSecondsRealtime(2.0f);
        }            
    }
}
