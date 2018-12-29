using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase : State {

	public StateBase (string inType) {
		
		type = inType;
		
	}

	public override void Start () {
		
		base.Start();
		
	}
	
	public override void Update (bool active, int input) {
		
		base.Update(active, input);
		
		if (active == true) {
			Game.game.stateMachine.NewState("splashscreen");
			
			// For testing.
			if (Input.GetKeyDown("a")) {
				Debug.Log("You're pressing A in the base state.");
			}
			if (Input.GetKeyDown("s")) {
				Game.game.stateMachine.NewState("test1");
			}
			if (Input.GetKeyDown("escape")) {
				Game.game.stateMachine.EndCurrentState();
			}
		}
		
	}
	
	public override void End () {
		
		base.End();
		
		Debug.Log("Quitting game.");
		Application.Quit();
		
	}
}
