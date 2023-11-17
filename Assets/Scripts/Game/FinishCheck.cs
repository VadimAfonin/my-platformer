using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class FinishCheck : MonoBehaviour
{
    [SerializeField] private GameObject _gameCanvas;
    [SerializeField] private GameObject _ui_popup;
    [SerializeField] private StarsPicController _starsPicController;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            _gameCanvas.SetActive(false);
            _ui_popup.SetActive(true);

            var stars = StarsCalculator.SetStarsPic(Statistics._levelPercent);
            Storage.SetStars(stars, SceneManager.GetActiveScene().buildIndex);
            _starsPicController.SetPicStars(stars);
        }
    }    

}    