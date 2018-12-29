using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State {
	
	public string type;
	
	public State () {
		
		type = "unknown";
		
	}
	
	public State (string inType) {
		
		type = inType;
		
	}
	
	public virtual void Start () {
		
		// To be extended by children.
		
	}
	
	public virtual void Update (bool active, int input) {

		// To be extended by children.
		
	}
	
	public virtual void End () {
		
		// To be extended by children.
		
	}
	
}
