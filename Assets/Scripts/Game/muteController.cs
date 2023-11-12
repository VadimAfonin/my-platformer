using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteController : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private Sprite _isMutedSprite;
    [SerializeField] private Sprite _nonMutedSprite;

    private static bool _isMuted;
    private Image img;
    //private AudioListener al;

    void Start()
    {
        _cam = GetComponent<Camera>();
        //al = GetComponent<AudioListener>();
        img = GetComponent<Image>();
    }

    public void OnMuteButtonClick()
    {
        _isMuted = !_isMuted;
        AudioListener.volume = _isMuted ? 0 : 1;
        img.sprite = _isMuted ? _isMutedSprite : _nonMutedSprite;        
    }       
}
