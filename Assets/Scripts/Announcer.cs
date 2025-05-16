using UnityEngine;
using System.Collections.Generic;

public class Announcer : MonoBehaviour
{
    public AudioClip[] announcements;
    private AudioSource source;
    private int monkeyCounter = 0;
    private int blockCounter = 0;
    private bool exitLineRead = false;
    public bgm bgm_;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (monkeyCounter >= 5 && !exitLineRead && !source.isPlaying)
        {
            source.PlayOneShot(announcements[6]);
            exitLineRead = true;
        }
        if (exitLineRead && !source.isPlaying)
        {
            gameObject.SetActive(false);
        }
    }

    public void Play(string audio_type)
    {
        if (exitLineRead)
        {
            return;
        }
        int i = 0;
        if (audio_type == "init")
        {
            i = 0;
        }
        else if (audio_type == "monkey")
        {
            i = 1 + monkeyCounter;
            monkeyCounter++;
        }
        else if (audio_type == "block")
        {
            i = 7 + blockCounter;
            blockCounter++;
        }
        if (blockCounter >= 5 && !exitLineRead && !source.isPlaying)
        {
            bgm_.gameObject.SetActive(false);
            source.PlayOneShot(announcements[12]);
            exitLineRead = true;
        }
        else
        {
            source.PlayOneShot(announcements[i]);
        }
    }
}
