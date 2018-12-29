using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

	List<State> stateList;

	// Use this for initialization
	public void Start () {
		
		Debug.Log("Starting State Machine.");
		stateList = new List<State>();
		NewState("base");
		
	}
	
	// Update is called once per frame
	public void Update () {
		
	}
	
	// Needs to be updated with specific input format stuff
	public void UpdateStates (int input) {
		
		for (int i = 0; i < stateList.Count; i++) {
			if (i < stateList.Count - 1) {
				stateList[i].Update(false, 0);
			} else if (i == stateList.Count - 1) {
				stateList[i].Update(true, input);
				break;
			}
		}
		
	}
	
	// Adds a new state to the state list.
	public void NewState (string type) {
		
		Debug.Log("Adding new state: " + type);
		switch (type) {
			case "base":
				stateList.Add(new StateBase(type));
				break;
			case "test1":
				stateList.Add(new StateTest1(type));
				break;
			case "test2":
				stateList.Add(new StateTest2(type));
				break;
			case "splashscreen":
				stateList.Add(new StateSplashScreen(type));
				break;
			case "title":
				stateList.Add(new StateTitle(type));
				break;
			default:
				stateList.Add(new State("unknown"));
				break;
		}
		stateList[stateList.Count - 1].Start();
		
	}
	
	// Ends the most recent state in the state list.
	public void EndCurrentState () {
		
		EndState(stateList.Count - 1);
		
	}
	
	// Ends a state with a specific state list index.
	public void EndState(int index) {
		
		if (stateList[index] != null) {
			Debug.Log("Ending state: " + stateList[index].type);
			stateList[index].End();
			stateList.RemoveAt(index);
			stateList.TrimExcess();
		} else {
			Debug.Log("Trying to end a state that doesn't exist.");
		}
		
	}
	
	// Ends all states and, by extension, the game.
	public void EndAllStates() {
		
		for (int i = stateList.Count - 1; i >= 0; i--) {
			EndState(i);
		}
		
	}
}