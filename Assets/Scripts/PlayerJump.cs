using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody2D _rb;

    public const float MAX_JUMPS = 2.0f;

    public float _jumpForce = 1.0f;
    private float _jumpsLeft = 0.0f;

    // Start is called before the first frame update
    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (IsGrounded()) _jumpsLeft = MAX_JUMPS;
        if (_jumpsLeft > 0.0f && _input._movementVertical)
        {
            _jumpsLeft -= 1.0f;
            _rb.velocity = new Vector2(_rb.velocity.x, 0.0f);
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        return _rb.velocity.y == 0;
    }
}