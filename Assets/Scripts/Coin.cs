using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private CoinCounting _coinCounting;
    public int _value;

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