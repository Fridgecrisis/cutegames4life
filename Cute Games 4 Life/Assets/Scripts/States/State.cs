using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour {
	
	public string type;
	public List<Trigger> triggerList;
	
	public State () {
		
		type = "unknown";
		
	}
	
	public State (string inType) {
		
		type = inType;
		
	}
	
	public virtual void Start () {
		
		foreach (Transform child in transform) {
			if (child.name == "Triggers") {
				foreach (Transform grandchild in child) {
					triggerList.Add(grandchild.gameObject.GetComponent<Trigger>());
				}
			}
		}
		// To be extended by children.
		
	}
	
	public virtual void Update () {
		
		// To be extended by children.
		
	}
	
	public virtual void UpdateActive () {

		UpdateTriggers();
		// To be extended by children.
		
	}
	
	public virtual void UpdateTriggers () {
		
		foreach (Trigger trigger in triggerList) {
			trigger.UpdateTrigger();
		}
		
	}
	
	public virtual void End () {
		
		// To be extended by children.
		
	}
	
}
