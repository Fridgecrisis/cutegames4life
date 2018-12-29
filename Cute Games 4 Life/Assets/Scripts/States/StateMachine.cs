using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

	public List<State> masterStateList;
	public List<State> currentStateList;

	// Use this for initialization
	public void Start () {
		
		Debug.Log("Starting State Machine.");
		foreach (Transform child in transform) {
			masterStateList.Add(child.gameObject.GetComponent<State>() as State);
		}
		currentStateList = new List<State>();
		NewState("base");
		
	}
	
	// Update is called once per frame
	public void Update () {
		
	}
	
	// Needs to be updated with specific input format stuff
	public void UpdateStates () {
		
		foreach (State state in currentStateList) {
			state.Update();
		}
		
		if (currentStateList.Count >= 1) {
			currentStateList[currentStateList.Count - 1].UpdateActive();
		}
		
	}
	
	// Adds a new state to the state list.
	public void NewState (string type) {
		
		Debug.Log("Adding new state: " + type);
		foreach (State state in masterStateList) {
			if (state.type == type) {
				currentStateList.Add(state);
			}
		}
		currentStateList[currentStateList.Count - 1].Start();
		
	}
	
	// Ends the most recent state in the state list.
	public void EndCurrentState () {
		
		EndState(currentStateList.Count - 1);
		
	}
	
	// Ends a state with a specific state list index.
	public void EndState(int index) {
		
		if (currentStateList[index] != null) {
			Debug.Log("Ending state: " + currentStateList[index].type);
			currentStateList[index].End();
			currentStateList.RemoveAt(index);
			currentStateList.TrimExcess();
		} else {
			Debug.Log("Trying to end a state that doesn't exist.");
		}
		
	}
	
	// Ends all states and, by extension, the game.
	public void EndAllStates() {
		
		for (int i = currentStateList.Count - 1; i >= 0; i--) {
			EndState(i);
		}
		
	}
}