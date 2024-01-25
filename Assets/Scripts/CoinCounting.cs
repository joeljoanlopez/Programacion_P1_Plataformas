using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounting : MonoBehaviour
{
    // Start is called before the first frame update
    public static CoinCounting _instance;
    public int _currentCoins = 0;
    private string _coinText;
    void Start()
    {
        _instance = this;

    }

    // Update is called once per frame
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), _coinText);
    }
    void Update()
    {
        _coinText = ("Coins: ") + _currentCoins.ToString();
    }
    public void IncreaseCoins(int _value)
    {
        _currentCoins += _value;
    }
}
