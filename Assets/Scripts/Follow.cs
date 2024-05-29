using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform _player;

    public void Update()
    {
        FollowParticl();
    }

    public void FollowParticl()
    {
        transform.position = _player.position;
    }
}
