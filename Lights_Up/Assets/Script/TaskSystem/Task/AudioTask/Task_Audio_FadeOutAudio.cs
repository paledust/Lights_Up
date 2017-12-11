using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Audio_FadeOutAudio : Task_Basic {
	[SerializeField] AudioSource m_audio;
	[SerializeField] float FadeOutTime;
	float StartVolume;
	float timer;
	// Use this for initialization
	public override void Init(){
		StartVolume = m_audio.volume;
		timer = 0.0f;
	}
	internal override void T_Update(){
		timer += Time.deltaTime/FadeOutTime;

		m_audio.volume = Mathf.Lerp(StartVolume, 0.0f, timer);

		if(timer >= 1){
			SetStatus(TaskStatus.Success);
		}
	}
}
