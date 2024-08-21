using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome2 : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    public const float START_SECONDS = 0.0f;
    public const float INTERVAL_SECONDS = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("PlaySound", START_SECONDS, INTERVAL_SECONDS);
    }

    private void PlaySound()
    {
        audioSource.Play();
    }
}
