using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Debug : Task_Basic {
	[SerializeField] string DebugMessage;
	// Use this for initialization
	public override void Init () {
		Debug.Log(DebugMessage);
		SetStatus(TaskStatus.Success);
	}

}
