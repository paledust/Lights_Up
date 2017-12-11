using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Task_Basic : MonoBehaviour {
#region InterFace_Value
	public enum TaskStatus{
		Detached, // Action has not been attached to a ActionManager
    	Pending, // Action has not been initialized
    	Working, // Action has been initialized
    	Success, // Action completed successfully
    	Fail, // Action completed unsuccessfully
    	Aborted // Action was aborted
	}
	public TaskStatus Status { get; protected set; }
	public bool IsDetached { get { return Status == TaskStatus.Detached; } }
	public bool IsAttached { get { return Status != TaskStatus.Detached; } }
	public bool IsPending { get { return Status == TaskStatus.Pending; } }
	public bool IsWorking { get { return Status == TaskStatus.Working; } }
	public bool IsSuccessful { get { return Status == TaskStatus.Success; } }
	public bool IsFailed { get { return Status == TaskStatus.Fail; } }
	public bool IsAborted { get { return Status == TaskStatus.Aborted; } }
	public bool IsFinished { get { return (Status == TaskStatus.Fail || Status == TaskStatus.Success || Status == TaskStatus.Aborted); } }
    #endregion
    public Task_Basic NextAction;

    internal void SetStatus(TaskStatus newStatus){
		if (Status == newStatus) return;

		Status = newStatus;

		switch (newStatus){
			case TaskStatus.Working:
				Init();
				break;
			case TaskStatus.Success:
				OnSuccess();
				CleanUp();
				break;
			case TaskStatus.Aborted:
				OnAbort();
				CleanUp();
				break;
			case TaskStatus.Fail:
				OnFail();
				CleanUp();
				break;
			case TaskStatus.Detached:
			case TaskStatus.Pending:
				break;
			default:
				Debug.Log("None status is found");
				Debug.Assert(false);
				break;
		}
	}

	protected virtual void Start(){
	}

#region StatusFunction
	internal virtual void T_Update(){}
	public virtual void Init(){}
	public virtual void OnAbort(){}
	public virtual void OnSuccess(){}
	public virtual void OnFail(){}
	public virtual void CleanUp(){}
#endregion
}
