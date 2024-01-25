using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int _value;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    //colision de jugador con moneda y suma del valor
    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            CoinCounting._instance.IncreaseCoins(_value);
        }
    }
}
