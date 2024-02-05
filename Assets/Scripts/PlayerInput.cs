using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float _movementHorizontal { get; private set; }
    public bool _movementVertical { get; private set; }

    public Animator _animator;
    private bool _hasJumped = false; // New variable to track jump state

    // Update is called once per frame
    private void Update()
    {
        _movementHorizontal = Input.GetAxis("Horizontal");
        _movementVertical = Input.GetButtonDown("Jump");

        if ((_movementVertical || Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow)) && !_hasJumped)
        {
            _animator.SetBool("Jumping", true);
            print("hello");
            _hasJumped = true; // Set the flag to true to indicate that the jump animation has played
        }
        else if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            _animator.SetFloat("Speed", 2);
        }
        else
        {
            _animator.SetBool("Jumping", false);
            _animator.SetFloat("Speed", 0);

            // Reset the jump flag when no longer pressing the jump key
            if (!Input.GetKey("w") && !Input.GetKey(KeyCode.UpArrow))
            {
                _hasJumped = false;
            }
        }
    }
}