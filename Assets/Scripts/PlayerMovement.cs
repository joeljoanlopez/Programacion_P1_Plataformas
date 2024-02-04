using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;

    public float _speed = 1.0f;


    private void Start()
    {
        _input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 direction = Vector2.right * _input._movementHorizontal * Time.deltaTime * _speed;

        transform.Translate(direction);
    }
}