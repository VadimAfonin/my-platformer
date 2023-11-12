using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(Button))]
public class Level_Selector : MonoBehaviour
{
    [SerializeField] private int _buildIndex;

    private void Awake()
    {
        var index = transform.GetChild(0);
        index.GetComponent<TMP_Text>().text = _buildIndex.ToString();

        var button = GetComponent<Button>();
        button.onClick.AddListener(OnLevelButtonClick);
    }

    void OnLevelButtonClick()
    {
        SceneManager.LoadScene(_buildIndex);
    }

}
