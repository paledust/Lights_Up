using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTask : MonoBehaviour {
	protected Task_Manager task_Manager;
	[SerializeField] protected List<Task_Basic> taskScripts;
	[SerializeField] protected bool IF_Attach = false;
	protected bool IF_Trigger = false;

    protected virtual void Start () {
		task_Manager = FindObjectOfType<Task_Manager>();
		taskScripts = new List<Task_Basic>();
        
        // Add all action scripts on child game objects to my list of actions.
		foreach(Task_Basic child in transform.GetComponentsInChildren<Task_Basic>()){
			if(child.transform.parent == transform)
				taskScripts.Add(child);
		}

		// IF_Attach = false;
		IF_Trigger = false;
	}

	protected virtual void Update () {
        // If we're ready to attach, then add the first action from my list to the action manager.
        if (IF_Attach && !IF_Trigger)
        {
            if (taskScripts[0].IsDetached) { task_Manager.AddTask(taskScripts[0]);}
            IF_Trigger = true;
        }

        // Set the status of my first action to 'success'.
        else if (!IF_Attach && IF_Trigger)
        {
            if (taskScripts[0].IsAttached) { 
				taskScripts[0].SetStatus(Task_Basic.TaskStatus.Success); 
				Debug.Log(taskScripts[0].name);
			}
            IF_Trigger = false;
        }
    }

	public void Activate_All_Action(){
		IF_Attach = true;
	}

    public void Deactivate_Action(){
		IF_Attach = false;
	}
	public void Reset_Action(){
		IF_Attach = false;
		IF_Trigger = false;
	}
	public bool IF_ATTACH(){
		return IF_Attach;
	}
}
