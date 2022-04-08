using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBlockBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform _playerOne;
    [SerializeField]
    private Transform _playerTwo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _playerOne.transform || other.transform == _playerTwo.transform)
        {
            _playerOne.transform.position = new Vector3(27, 5, 18);
            _playerTwo.transform.position = new Vector3(55, 5, 18);
        }

    }
}
