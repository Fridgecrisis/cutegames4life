using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Might not need these
public enum GameState {
	PAUSED,
	IN_WORLD,
	MOUNTED,
	UI
}

public class InputManager : MonoBehaviour {
	
	void Start () {
		
	}
	
	void Update () {
		
	}
	
	// Dummy function for now. Not sure how I'm going to pass along the input...
	public int GetInput () {
		// Check for input here
		return 1;
	}
}
