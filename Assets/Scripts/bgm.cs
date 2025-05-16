using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm: MonoBehaviour
{
	public AudioClip[] sounds;
	public GameObject announcer;
	private AudioSource announceSource;
	private float volumeDefault;
	private AudioSource source;

	void Start(){
		source = GetComponent<AudioSource>();
		volumeDefault = source.volume;
		announceSource = announcer.GetComponent<AudioSource>();
		AudioClip clip = sounds[Random.Range(0, sounds.Length-1)];
		source.PlayOneShot(clip);
	}

	private void Update(){
		if (announceSource.isPlaying)
		{
			source.volume = volumeDefault / 5;
		}
		else
		{
			source.volume = volumeDefault;
		}
		if (!source.isPlaying){
			AudioClip clip = sounds[Random.Range(0, sounds.Length-1)];
			source.PlayOneShot(clip);
		}
	}
}