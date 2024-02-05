using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private bool _kills;
    public static bool _isDead;
    private Rigidbody2D _rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rb = collision.GetComponent<Rigidbody2D>();
        if (_rb != null)
        {
            _isDead = _kills;
            SceneManager.LoadScene("GameOver");
        }
    }
}