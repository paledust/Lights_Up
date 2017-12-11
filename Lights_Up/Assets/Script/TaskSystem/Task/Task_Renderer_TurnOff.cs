using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Renderer_TurnOff : Task_Basic {
	[SerializeField] Renderer TargetRenderer;
	// Use this for initialization
	public override void Init(){
		TargetRenderer.enabled = false;
		SetStatus(TaskStatus.Success);
	}
}
