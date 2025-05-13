using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm: MonoBehaviour
{
	public AudioClip[] sounds;

	private AudioSource source;

	void Start(){
		source = GetComponent<AudioSource>();

		AudioClip clip = sounds[Random.Range(0, sounds.Length-1)];
		source.PlayOneShot(clip);
	}

	private void Update(){
		
		if (!source.isPlaying){
			AudioClip clip = sounds[Random.Range(0, sounds.Length-1)];
			source.PlayOneShot(clip);
		}
	}
}