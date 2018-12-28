using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateTest2 : State {

	public StateTest2 (string inType) {
		
		type = inType;
		
	}

	public override void Start () {
		
		base.Start();
		
	}
	
	public override void Update (bool active, int input) {
		
		base.Update(active, input);
		
		if (active == true) {
			if (Input.GetKeyDown("a")) {
				Debug.Log("You're pressing A in the test2 state.");
			}
			if (Input.GetKeyDown("escape")) {
				Game.game.stateMachine.EndCurrentState();
			}
		}
		
	}
	
	public override void End () {
		
		base.End();
		
	}
}
