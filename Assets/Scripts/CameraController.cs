using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _playerT;

    private Vector3 _offset;

    public void Start()
    {
        _offset = transform.position - _playerT.position;
    }

    public void FixedUpdate()
    {
        transform.position = _playerT.position + _offset;
    }
}
