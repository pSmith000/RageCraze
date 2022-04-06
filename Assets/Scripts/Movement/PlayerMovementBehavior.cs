using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _rotationSpeed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Vector2 _rotationDirection;

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }


    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (MoveDirection != Vector3.zero)
        {
            _rigidbody.AddForce(transform.forward + MoveDirection * _speed * Time.fixedDeltaTime, ForceMode.Impulse);
        }
        
    }
}
