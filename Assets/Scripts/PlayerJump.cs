using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody2D _rb;
    private CollisionChecker _collisionChecker;
    private bool _hasPowerUp;

    [SerializeField]
    private int _maxJumps = 2;

    [SerializeField]
    private float _jumpForce = 1.0f;

    [SerializeField]
    private int _jumpsLeft = 0;

    public AudioSource _jumpSound;

    // Start is called before the first frame update
    private void Start()
    {
        _hasPowerUp = false;
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody2D>();
        _collisionChecker = GetComponent<CollisionChecker>();
    }

    private void FixedUpdate()
    {
        _jumpsLeft = _collisionChecker.IsGrounded ? _maxJumps : Mathf.Min(_maxJumps - 1, _jumpsLeft);
    }

    // Update is called once per frame
    private void Update()
    {
        if (_hasPowerUp)
        {
            _jumpForce = 6.0f;
        }
        if (_jumpsLeft >= 1 && _input._movementVertical)
        {
            _jumpSound.Play();
            _jumpsLeft -= 1;
            _rb.velocity = Vector2.up * _rb.velocity.x;
            _rb.AddForce(Vector2.up * _jumpForce * _rb.gravityScale, ForceMode2D.Impulse);
        }
    }

    public void GetPowerUp()
    {
        _hasPowerUp = true;
    }
}