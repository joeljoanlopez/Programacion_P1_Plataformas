using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool _isDead;
    private Rigidbody2D _rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rb = collision.GetComponent<Rigidbody2D>();
        if (_rb != null)
        {
            SceneManager.LoadScene("GameOver");
            if (_isDead)
            {
                PlayerPrefs.GetInt("final", 0);

            }
            else if (!_isDead)
            {
                PlayerPrefs.GetInt("final", 1);
            }

        }
    }
}