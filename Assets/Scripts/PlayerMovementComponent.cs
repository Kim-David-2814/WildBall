using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WildBall.input
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovementComponent : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float _speed;
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            _rb.AddForce(movement * _speed);
        }
    }
}
