using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioClip _musicClip;

    public AudioSource _musicSource;

    private void Start()
    {
        _musicClip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    private void Update()
    {
        _musicSource.Play();
    }
}