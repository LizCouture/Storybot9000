using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prompts : MonoBehaviour {

	public List<AudioClip> promptVocals;
	public List<AudioClip> unusedPrompts;
	public AudioClip greeting;
	public static AudioSource audio;

	void Start(){
	 audio = GetComponent<AudioSource>();
		for(int i=0;i<promptVocals.Count;i++){
			unusedPrompts.Add(promptVocals[i]);
		}
	}

	public void playRandomClip(){
		//audio.clip = promptVocals[Random.Range(0,promptVocals.Length)];
		if(unusedPrompts.Count <= 0){
			for(int i=0;i<promptVocals.Count;i++){
				unusedPrompts.Add(promptVocals[i]);
			}
		}
		int clip = Random.Range(0,unusedPrompts.Count);
		audio.clip = unusedPrompts[clip];
		unusedPrompts.RemoveAt(clip);
		audio.Play();
	}

	public void playGreeting(){
		audio.clip = greeting;
		audio.Play();
	}
}
