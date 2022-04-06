using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementBehavior _playerOne;
    [SerializeField]
    private PlayerMovementBehavior _playerTwo;
    private float _cameraHeight;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = new Quaternion(90, 0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOnePos = _playerOne.transform.position;
        Vector3 playerTwoPos = _playerTwo.transform.position;
        Vector3 zMidpoint = (playerOnePos + playerTwoPos) / 2f;
        _cameraHeight = Vector3.Distance(playerOnePos, playerTwoPos);
        if (_cameraHeight < 50)
            _cameraHeight = 50;
        transform.position = new Vector3(zMidpoint.x, zMidpoint.y + _cameraHeight, zMidpoint.z);
    }
}
