using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowStats : MonoBehaviour
{
    [SerializeField] private TMP_Text _totalMosters;
    [SerializeField] private TMP_Text _totalCoins;
    [SerializeField] private TMP_Text _totalLives;    
    

    public void GetTotalStats()
    {
        _totalCoins.text = Statistics._coinsCollectedTotal.ToString();
        _totalMosters.text = Statistics._enemiesKilledTotal.ToString();
        _totalLives.text = Statistics._livesUsed.ToString();
    }
}
