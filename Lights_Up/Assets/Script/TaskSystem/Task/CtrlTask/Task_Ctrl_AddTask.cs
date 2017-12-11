using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Ctrl_AddTask : Task_Basic {
	[SerializeField] List<Task_Basic> TargetTasks;
	// Use this for initialization
	public override void Init(){
		foreach(Task_Basic task in TargetTasks){
			Debug.Assert(task.Status == Task_Basic.TaskStatus.Detached);
			FindObjectOfType<Task_Manager>().AddTask(task);
			SetStatus(TaskStatus.Success);
		}
	}
}
