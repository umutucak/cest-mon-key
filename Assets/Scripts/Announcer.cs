using UnityEngine;
using System.Collections.Generic;

public class Announcer : MonoBehaviour
{
    public AudioClip[] announcements;
    public GameObject godCorner;
    private bool godCanSkypeCall = false;
    private bool godIsSkyping = false;
    private AudioSource source;
    private int monkeyCounter = 0;
    private int blockCounter = 0;
    private bool exitLineRead = false;
    public bgm bgm_;
    private Queue<AudioClip> audioManager = new Queue<AudioClip>();

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && audioManager.Count == 1)
        {
            source.Stop();
        }
        if (audioManager.Count > 0 && !source.isPlaying)
        {
            AudioClip audio = audioManager.Dequeue();
            if (audioManager.Count == 1)
                godIsSkyping = true;
            source.PlayOneShot(audio);
        }
        if (source.isPlaying && godCanSkypeCall)
            godCorner.SetActive(true);
        else
        {
            godCanSkypeCall = false;
            godCorner.SetActive(false);
        }

        if (monkeyCounter >= 5 && !exitLineRead && !source.isPlaying)
        {
            audioManager.Enqueue(announcements[13]);
            audioManager.Enqueue(announcements[6]);
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
            return;

        int i = 0;
        if (audio_type == "init")
            i = 0;
        else if (audio_type == "monkey")
        {
            i = 1 + monkeyCounter;
            monkeyCounter++;
            godCanSkypeCall = true;
        }
        else if (audio_type == "block")
        {
            i = 7 + blockCounter;
            blockCounter++;
            godCanSkypeCall = true;
        }
        if (blockCounter >= 5 && !exitLineRead && !source.isPlaying)
        {
            bgm_.gameObject.SetActive(false);
            audioManager.Enqueue(announcements[13]);
            audioManager.Enqueue(announcements[12]);
            exitLineRead = true;
        }
        else if (i == 0)
            audioManager.Enqueue(announcements[i]);
        else
        {
            audioManager.Enqueue(announcements[13]);
            audioManager.Enqueue(announcements[i]);
        }
    }
}
