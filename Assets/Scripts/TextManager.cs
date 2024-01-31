using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Text _text;

    void Start()
    {
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
   
        if (PlayerPrefs.GetInt("final") == 0)
        {
            _text.text = ("You died");
        }
        if (PlayerPrefs.GetInt("final") == 1 )
        {
            _text.text = ("You win");
        }
    }
}
