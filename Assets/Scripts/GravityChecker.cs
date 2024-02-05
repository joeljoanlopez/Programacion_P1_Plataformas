using UnityEngine;

public class GravityChecker : MonoBehaviour
{
    private Rigidbody2D _rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rb = collision.GetComponent<Rigidbody2D>();
        _rb.gravityScale *= -1;
        collision.transform.localScale *= new Vector2(1, -1);
    }
}