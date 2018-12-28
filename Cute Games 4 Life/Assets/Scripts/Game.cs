using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public InputManager inputManager;
	public StateMachine stateMachine;
	public EventHandler eventHandler;

	// Use this for initialization
	void Start () {
		
		stateMachine.NewState("base");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		inputManager.Update();
		stateMachine.Update(inputManager.GetInput());
		
	}
}
