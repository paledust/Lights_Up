using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Audio_FadeInAudio : Task_Basic {
	[SerializeField] AudioSource m_audio;
	[SerializeField] AudioClip SoundClip;
	[SerializeField] bool If_Loop;
	[SerializeField] float FadeinTime;
	float timer;
	// Use this for initialization
	public override void Init(){
		timer = 0.0f;
		m_audio.volume = 0.0f;
		if(If_Loop){
			m_audio.loop = true;
			m_audio.clip = SoundClip;
			m_audio.Play();
		}
		else{
			m_audio.PlayOneShot(SoundClip);
		}
	}
	internal override void T_Update(){
		timer += Time.deltaTime/FadeinTime;

		m_audio.volume = Mathf.Lerp(0, 1.0f, timer);

		if(timer >= 1){
			SetStatus(TaskStatus.Success);
		}
	}
}
