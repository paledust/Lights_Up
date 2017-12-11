using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Particle_Emitt : Task_Basic {
	[SerializeField] ParticleSystem particle;
	// Use this for initialization
	public override void Init(){
		var Emitter = particle.emission;
		Emitter.enabled = true;

		SetStatus(TaskStatus.Success);
	}
}
