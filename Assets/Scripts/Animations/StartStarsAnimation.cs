using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStarsAnimation : MonoBehaviour
{
    [SerializeField] private GameObject _uiPopup;

    private Animator _anim;


    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (_uiPopup.activeSelf)
        {            
            _anim.SetTrigger("FinishUi_Opened");
        }
    }
}
