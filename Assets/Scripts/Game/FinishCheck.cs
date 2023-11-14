using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCheck : MonoBehaviour
{
    [SerializeField] private GameObject _gameCanvas;
    [SerializeField] private GameObject _ui_popup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            _gameCanvas.SetActive(false);
            _ui_popup.SetActive(true);
        }
    }    
}    