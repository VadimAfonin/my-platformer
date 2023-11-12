using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLooseController : MonoBehaviour
{
    //[SerializeField] private GameObject _youLooseScreen;


    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.CompareTag("DeathTrigger"))
        {
            Time.timeScale = 0;
            //_youLooseScreen.SetActive(true);
        }
    }
}
