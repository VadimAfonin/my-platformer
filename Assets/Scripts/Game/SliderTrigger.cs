using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _tipText;    

    [SerializeField] private SliderJoint2D joint;

    private void Start()
    {
        joint = GetComponent<SliderJoint2D>();
        joint.useMotor = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            _tipText.SetActive(true);
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            joint.useMotor = true;
        }
    }
}
