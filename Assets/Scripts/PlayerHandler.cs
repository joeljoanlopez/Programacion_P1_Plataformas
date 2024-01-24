using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody2D _rb;

    public float _speed = 1.0f;
    public float _jumpForce = 1.0f;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 direction = new Vector2(_input.MovementHorizontal, 0) * Time.deltaTime * _speed;
        transform.Translate(direction);

        if (IsGrounded() && _input.MovementVertical)
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private bool IsGrounded()
    {
        return _rb.velocity.y == 0;
    }
}