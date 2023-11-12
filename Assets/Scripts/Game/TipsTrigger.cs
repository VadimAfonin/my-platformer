using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _tipText;
    [SerializeField] private Rigidbody2D _body;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            _tipText.SetActive(true);
        }        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _tipText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _body.AddForce(Vector2.right * 3, ForceMode2D.Impulse);
            _tipText.SetActive(false);
        }
    }
}
