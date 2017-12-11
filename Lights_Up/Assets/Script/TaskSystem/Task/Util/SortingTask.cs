using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingTask : MonoBehaviour {
	[SerializeField] protected List<Task_Basic> taskScripts;
	// Use this for initialization
	void Start () {
		foreach(Task_Basic child in transform.GetComponentsInChildren<Task_Basic>()){
			if(child.transform.parent == transform){
				taskScripts.Add(child);
				Transform nextSibling = null;
				if (child.transform.GetSiblingIndex() < transform.childCount - 1) { nextSibling = transform.GetChild(child.transform.GetSiblingIndex() + 1); }
				if (nextSibling != null && nextSibling.GetComponent<Task_Basic>()) { child.GetComponent<Task_Basic>().NextAction = nextSibling.GetComponent<Task_Basic>(); }
			}
		}
	}
}
