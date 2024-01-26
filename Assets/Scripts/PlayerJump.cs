using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody2D _rb;
    private CollisionChecker _collisionChecker;

    [SerializeField]
    private int _maxJumps = 2;
    [SerializeField]
    private float _jumpForce = 1.0f;
    [SerializeField]
    private int _jumpsLeft = 0;

    // Start is called before the first frame update
    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody2D>();
        _collisionChecker = GetComponent<CollisionChecker>();
    }

    private void FixedUpdate()
    {
        _jumpsLeft = _collisionChecker.IsGrounded ? _maxJumps : Mathf.Min(_jumpsLeft, 1);
    }

    // Update is called once per frame
    private void Update()
    {
        if (_jumpsLeft >= 1 && _input._movementVertical)
        {
            _jumpsLeft -= 1;
            _rb.velocity = Vector2.up * _rb.velocity.x;
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }
}