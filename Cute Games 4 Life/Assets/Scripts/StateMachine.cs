using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

	State[] stateArray;

	// Use this for initialization
	void Start () {
		
		State[] stateArray = new State[] {};
		
	}
	
	// Update is called once per frame
	public void Update () {
		
	}
	
	// Needs to be updated with specific input format stuff
	public void Update (int input) {
		
		for (int i = 0; i < stateArray.Length; i++) {
			if (i < stateArray.Length) {
				stateArray[i].Update(false, 0);
			} else {
				stateArray[i].Update(true, input);
			}
		}
		
	}
	
	// Creates a new instance of a state and a new, larger array to contain it.
	public void NewState (string type) {
		
		State newState = new State(type);
		State[] newArray = new State[stateArray.Length + 1];
		System.Array.Copy(stateArray, newArray, stateArray.Length);
		newArray[newArray.Length] = newState;
		stateArray = newArray;
		
	}
	
	public void EndState () {
		
		stateArray[stateArray.Length].End();
		State[] newArray = new State[stateArray.Length - 1];
		System.Array.Copy(stateArray, newArray, stateArray.Length - 1);
		stateArray = newArray;
		
	}
	
}
