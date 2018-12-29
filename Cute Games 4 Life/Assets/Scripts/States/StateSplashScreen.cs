using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateSplashScreen : State {

	int timer = 0;

	public StateSplashScreen (string inType) {
		
		type = inType;
		
	}

	public override void Start () {
		
		base.Start();
		
		Debug.Log("Loading Splash Screen");
		SceneManager.LoadScene("SplashScreen", LoadSceneMode.Additive);
		timer = 100;
		
	}
	
	public override void Update (bool active, int input) {
		
		base.Update(active, input);
		
		if (active == true) {
			if (Input.GetKeyDown("escape") || Input.GetKeyDown("return")) {
				timer = 0;
			}
			if (timer <= 0) {
				Game.game.stateMachine.EndCurrentState();
				Game.game.stateMachine.NewState("title");
			} else {
				timer -= 1;
			}
		}
		
	}
	
	public override void End () {
		
		base.End();
		
		Debug.Log("Unloading Splash Screen");
		SceneManager.UnloadSceneAsync("SplashScreen");
		
	}
}
