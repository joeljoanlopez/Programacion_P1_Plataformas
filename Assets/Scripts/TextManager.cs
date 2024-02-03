using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        GetComponent<Text>().text = GameOver._text;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}