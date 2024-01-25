using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public int _value;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            CoinCounting._instance.IncreaseCoins(_value);
            print(_value);
        }
    }
}
