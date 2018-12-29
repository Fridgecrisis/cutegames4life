using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateTest1 : State {

	public StateTest1 (string inType) {
		
		type = inType;
		
	}

	public override void Start () {
		
		base.Start();
		
		Debug.Log("Loading Level1");
		SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
		
	}
	
	public override void Update (bool active, int input) {
		
		base.Update(active, input);
		
		if (active == true) {
			if (Input.GetKeyDown("a")) {
				Debug.Log("You're pressing A in the test1 state.");
			}
			if (Input.GetKeyDown("s")) {
				Game.game.stateMachine.NewState("test2");
			}
			if (Input.GetKeyDown("escape")) {
				Game.game.stateMachine.EndCurrentState();
			}
		}
		
	}
	
	public override void End () {
		
		base.End();
		
		Debug.Log("Unloading Level1");
		SceneManager.UnloadSceneAsync("Level1");
		
	}
}
