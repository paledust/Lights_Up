using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Audio_PlayAudio : Task_Basic {
	[SerializeField] AudioSource m_audio;
	[SerializeField] AudioClip SoundClip;
	[SerializeField] bool IF_RandomPitch = false;
	[SerializeField] bool If_Loop;
	// Use this for initialization
	public override void Init(){
		if(m_audio == null){
			m_audio = GameObject.Find("Audio").GetComponent<AudioSource>();
		}
		if(IF_RandomPitch){
			m_audio.pitch = Random.Range(0.8f,1.0f);
		}

		if(If_Loop){
			m_audio.loop = true;
			m_audio.clip = SoundClip;
			m_audio.Play();
		}
		else{
			m_audio.PlayOneShot(SoundClip);
		}

		SetStatus(TaskStatus.Success);
	}
	public override void OnAbort(){
		if(If_Loop){
			m_audio.Stop();
		}
	}
}
