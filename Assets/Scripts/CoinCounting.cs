using UnityEngine;

public class CoinCounting : MonoBehaviour
{
    public int _currentCoins = 0;
    private string _coinText;

    //dibuja en pantalla
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), _coinText);
    }

    private void Update()
    {
        _coinText = ("Coins: ") + _currentCoins.ToString();
    }

    //suma valor
    public void IncreaseCoins(int _value)
    {
        _currentCoins += _value;
    }
}