using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpChecker : MonoBehaviour
{
    private PlayerJump _playerJump;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        _playerJump = collision.GetComponent<PlayerJump>();
        if (_playerJump != null)
        {
            _playerJump.GetPowerUp();
        }
    }
}
