using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioClip _musicClip;
    public AudioSource _musicSource;
    void Start()
    {
        _musicClip = GetComponent<AudioClip>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _musicSource.Play();
    }
}
