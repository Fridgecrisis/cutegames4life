using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateSplashScreen : State {

	public StateSplashScreen (string inType) {
		
		type = inType;
		
	}

	public override void Start () {
		
		base.Start();
		
		Debug.Log("Loading Splash Screen");
		SceneManager.LoadScene("SplashScreen", LoadSceneMode.Additive);
		
	}
	
	public override void Update () {
		
		base.Update();
		
	}
	
	public override void UpdateActive () {
		
		base.UpdateActive();
		
		/* if (Input.GetKeyDown("escape") || Input.GetKeyDown("return")) {
			foreach (TriggerTimer trigger in triggerList) {
				if (trigger is TriggerTimer) {
					trigger.time = 0;
				}
			}
		} */
		
	}
	
	public override void End () {
		
		base.End();
		
		Debug.Log("Unloading Splash Screen");
		SceneManager.UnloadSceneAsync("SplashScreen");
		
	}
}
