using UnityEngine;

public class FlipHandler : MonoBehaviour
{
    private PlayerInput _input;
    private SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        _spriteRenderer.flipX = _input._movementHorizontal / Mathf.Abs(_input._movementHorizontal) > 0;
    }
}