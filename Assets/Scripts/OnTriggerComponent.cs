using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class OnTriggerComponent : MonoBehaviour
{
    public ParticleSystem _death;
    public GameObject _player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.CompareTag("Dead"))
        {
            _player.SetActive(false);
            _death.Play();
        }
    }
}
