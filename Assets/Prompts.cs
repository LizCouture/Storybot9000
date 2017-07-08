using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prompts : MonoBehaviour {

	public AudioClip[] promptVocals;
	public AudioClip greeting;
	public static AudioSource audio;

	void Start(){
	 audio = GetComponent<AudioSource>();
	}

	public void playRandomClip(){
		audio.clip = promptVocals[Random.Range(0,promptVocals.Length)];
		audio.Play();
	}

	public void playGreeting(){
		audio.clip = greeting;
		audio.Play();
	}
}
