using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Text>().text = GameOver._text;
    }
}