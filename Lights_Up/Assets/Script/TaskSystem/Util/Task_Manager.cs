using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_Manager : MonoBehaviour {

	List<Task_Basic> actionList = new List<Task_Basic>();
	
    //Update All Acton Attached to the Manager
	public void Update(){
		// iterate through all the tasks
		for (int i = actionList.Count - 1; i >= 0; --i){
			Task_Basic action = actionList[i];
			// Initialize any tasks that have just been added        
			if (action.IsPending){
				action.SetStatus(Task_Basic.TaskStatus.Working);
			}

            // Handle any tasks which have been completed.
			if (action.IsFinished){
				HandleCompletion(action, i);
			}

            // If the current task has not been completed, run its update function and then check one more time to see if it's finished.
			else{
				action.T_Update();
				if (action.IsFinished){
					HandleCompletion(action, i);
				}
			}
		}
	}

	//Handle the completion when an Action is done
	private void HandleCompletion(Task_Basic action, int actionIndex){
		if (action.NextAction != null && action.IsSuccessful){
			AddTask(action.NextAction);
		}
		actionList.RemoveAt(actionIndex);
		action.SetStatus(Task_Basic.TaskStatus.Detached);
	}
	
    //Add an action to the Manager
	public void AddTask(Task_Basic action){
		Debug.Assert(action != null);
    	Debug.Assert(!action.IsAttached);
    	actionList.Add(action);
    	action.SetStatus(Task_Basic.TaskStatus.Pending);
	}
}
