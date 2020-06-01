using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioTimer : MonoBehaviour
{
    public AudioSource citySound;
    // Start is called before the first frame update
    void Start()
    {
        citySound = GetComponent<AudioSource>();
        citySound.PlayDelayed(10.0f);
    }
}
