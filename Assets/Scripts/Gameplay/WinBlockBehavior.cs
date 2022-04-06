using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBlockBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform _playerOne;
    [SerializeField]
    private Transform _playerTwo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _playerOne.transform && other.transform == _playerTwo.transform)
        {
            Application.Quit();
        }

    }
}
