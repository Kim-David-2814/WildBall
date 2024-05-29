using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControllerAnim : MonoBehaviour
{
    private Animator _anim;
    private Rigidbody _rb;

    public void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }

    public void Update()
    {
        AnimationCube();
    }

    public void AnimationCube()
    {
        _anim.SetFloat("Speed", _rb.velocity.magnitude);
    }
}
