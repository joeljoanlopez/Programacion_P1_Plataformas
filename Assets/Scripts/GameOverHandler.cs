using UnityEngine;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private GameObject _dieMessage;
    [SerializeField] private GameObject _winMessage;

    // Start is called before the first frame update
    private void Start()
    {
        if (GameOverController._isDead)
        {
            _winMessage.SetActive(false);
            _dieMessage.SetActive(true);
        }
        else
        {
            _dieMessage.SetActive(false);
            _winMessage.SetActive(true);
        }
    }
}