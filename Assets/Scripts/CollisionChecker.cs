using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    [SerializeField] private LayerMask _whatIsGround;
    [SerializeField] private Transform _groundChecker;
    [SerializeField] private bool _isGrounded;
    public bool IsGrounded { get { return _isGrounded; } }
    [SerializeField] private float _checkRadius = 0.10f;

    void FixedUpdate()
    {
        CheckGrounded();
    }

    public void CheckGrounded()
    {
        var _colliders = Physics2D.OverlapCircleAll(_groundChecker.position, _checkRadius, _whatIsGround);
        _isGrounded = _colliders.Length > 0;
    }
}
