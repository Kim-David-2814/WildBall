using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.input
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMovementComponent _move;
        private Vector3 _movement;

        private void Awake()
        {
            _move = GetComponent<PlayerMovementComponent>();
        }

        private void Update()
        {
            PlayerMove();
        }

        private void PlayerMove()
        {
            float horizontal = Input.GetAxis(GlobalStringVars._horizontalAxis);
            float vertical = Input.GetAxis(GlobalStringVars._verticalAxis);

            _movement = new Vector3(-vertical, 0, horizontal);
        }

        private void FixedUpdate()
        {
            _move.MoveCharacter(_movement);
        }
    }
}