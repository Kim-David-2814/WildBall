using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishComponent : MonoBehaviour
{
    public GameObject _win;
    public GameObject _win2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _win.SetActive(true);
            _win2.SetActive(true);
        }
    }
}
