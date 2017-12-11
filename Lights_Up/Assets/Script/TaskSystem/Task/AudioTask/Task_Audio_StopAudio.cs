using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Audio_StopAudio : Task_Basic {
	[SerializeField] AudioSource m_audio;
	// Use this for initialization
	public override void Init(){
		m_audio.Stop();

		SetStatus(TaskStatus.Success);
	}
}
