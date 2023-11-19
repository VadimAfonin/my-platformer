using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoresCalculator : MonoBehaviour
{
   // [SerializeField] private TMP_Text _levelCoinsText;
    [SerializeField] private TMP_Text _totalCoinsText;
   // [SerializeField] private TMP_Text _levelMonsterText;
    [SerializeField] private TMP_Text _totalMonsterText;
    [SerializeField] private TMP_Text _total_livesText;

    private void Update()
    {
       // _levelCoinsText.text = Statistics._coinsCollected.ToString();
        _totalCoinsText.text = Statistics._coinsCollectedTotal.ToString();
       // _levelMonsterText.text = Statistics._enemiesKilled.ToString();
        _totalMonsterText.text = Statistics._enemiesKilledTotal.ToString();
        _total_livesText.text = Statistics._livesUsed.ToString();
    }
}
