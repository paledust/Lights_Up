using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Ctrl_EnableScript : Task_Basic {
	[SerializeField] MonoBehaviour Script;
	// Use this for initialization
	public override void Init(){
		Script.enabled = true;
		SetStatus(TaskStatus.Success);
	}
}
