using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Audio_SetVolum : Task_Basic {
	[SerializeField] AudioSource m_audio;
	[SerializeField] float TargetVolume;
	[SerializeField] float WaitTime;
	float StartVolume;
	float timer;

	public override void Init(){
		timer = 0.0f;
		StartVolume = m_audio.volume;
	}
	internal override void T_Update(){
		timer += Time.deltaTime/WaitTime;

		m_audio.volume = Mathf.Lerp(StartVolume, TargetVolume, timer);

		if(timer >= 1){
			SetStatus(TaskStatus.Success);
		}
	}
}
