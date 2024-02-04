using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float _movementHorizontal { get; private set; }
    public bool _movementVertical { get; private set; }

    public Animator _animator;
    // Update is called once per frame
    private void Update()
    {
        _movementHorizontal = Input.GetAxis("Horizontal");
        _movementVertical = Input.GetButtonDown("Jump");
        if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            _animator.SetFloat("Speed", 2);
        }
        else
        {
            _animator.SetFloat("Speed", 0);

        }
    }
}