using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Ctrl_AbortTask : Task_Basic {
	[SerializeField] Task_Basic targetTask;
	// Use this for initialization
	public override void Init(){
		targetTask.SetStatus(TaskStatus.Aborted);
		SetStatus(TaskStatus.Success);
	}
}
