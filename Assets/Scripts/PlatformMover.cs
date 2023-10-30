using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _finishPosition;

    private float _speed = 0.025f;
    private Transform target;

    private void Start()
    {
        transform.position = _startPosition.position;
        target = _finishPosition;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed);
        if (transform.position == target.position)
        {
            if (target == _finishPosition)
            {
                target = _startPosition;
            }
            else if (target = _startPosition)
            {
                target = _finishPosition;
            }
        }
    }
}
