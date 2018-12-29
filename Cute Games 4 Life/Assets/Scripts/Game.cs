using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public static Game game;

	public InputManager inputManager;
	public StateMachine stateMachine;
	public EventHandler eventHandler;

	// Use this for initialization
	void Start () {
		
		game = this;
		stateMachine.Start();
		eventHandler.Start();
		
	}
	
	// Update is called once per frame
	void Update () {
	
		stateMachine.UpdateStates();
		
	}
	
	public static void NewState (string type) {
		
		game.stateMachine.NewState(type);
		
	}
	
	public static void EndCurrentState () {
		
		game.stateMachine.EndCurrentState();
		
	}
	
}
