using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool _isDead;
    private Rigidbody2D _rb;
    public static string _text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rb = collision.GetComponent<Rigidbody2D>();
        if (_rb != null)
        {
            if (_isDead)
            {
                _text = "You Died!";
            }
            else
            {
                _text = "You Win!";
            }
            SceneManager.LoadScene("GameOver");
        }
    }
}