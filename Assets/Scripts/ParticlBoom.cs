using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlBoom : MonoBehaviour
{
    public ParticleSystem _particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _particle.Play();

            gameObject.SetActive(false);
        }
    }
}
