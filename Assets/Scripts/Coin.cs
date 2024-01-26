using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private CoinCounting _coinCounting;
    public int _value;

    private void Start()
    {
       _coinCounting = GetComponent<CoinCounting>();
    }

    //colision de jugador con moneda y suma del valor
    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            _coinCounting.IncreaseCoins(_value);
        }
    }
}
