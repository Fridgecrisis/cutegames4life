using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateTitle : State {

	int index = 0;
	int indexMax = 3;
	Cursor cursor;
	Canvas canvas;

	public StateTitle (string inType) {
		
		type = inType;
		
	}

	public override void Start () {
		
		base.Start();
		
		Debug.Log("Loading Title");
		SceneManager.LoadScene("Title", LoadSceneMode.Additive);
		index = 0;
		
	}
	
	public override void Update (bool active, int input) {
		
		base.Update(active, input);
		
		if (active == true) {
			LookForCursor();
			UpdateCanvasRenderCamera();
			if (Input.GetKeyDown("escape")) {
				if (index != 3) {
					CursorSet(3);
					UpdateCursorPosition();
				} else if (index == 3) {
					Game.game.stateMachine.EndAllStates();
				}
			} else if (Input.GetKeyDown("return")) {
				Debug.Log("Selection: " + index);
				switch (index) {
					case 0:
						// New Game
						break;
					case 1:
						// Continue
						break;
					case 2:
						// Options
						break;
					case 3:
						// Quit
						Game.game.stateMachine.EndAllStates();
						break;
					default:
						break;
				}
			} else if (Input.GetKeyDown("up")) {
				CursorUp();
				UpdateCursorPosition();
			} else if (Input.GetKeyDown("down")) {
				CursorDown();
				UpdateCursorPosition();
			}
		}
		
	}
	
	void LookForCursor() {
		
		if (cursor == null) {
			Debug.Log("Looking for cursor.");
			GameObject cursorObject = GameObject.Find("Cursor");
			if (cursorObject != null) {
				cursor = cursorObject.GetComponent(typeof(Cursor)) as Cursor;
				Debug.Log("Cursor found.");
			}
		}
		
	}
	
	void UpdateCanvasRenderCamera() {
		
		if (canvas == null) {
			Debug.Log("Looking for canvas.");
			GameObject canvasObject = GameObject.Find("Canvas");
			if (canvasObject != null) {
				canvas = canvasObject.GetComponent(typeof(Canvas)) as Canvas;
				Debug.Log("Canvas found.");
				canvas.worldCamera = GameObject.Find("Main Camera").GetComponent(typeof(Camera)) as Camera;
				UpdateCursorPosition();
			}
		}
		
	}
	
	void UpdateCursorPosition () {
		
		if (cursor != null) {
			cursor.SetNewDestination(new Vector3(canvas.transform.position.x - 20, canvas.transform.position.y - 5 - (index * 5), canvas.transform.position.z));
		}
		
	}
	
	void CursorUp () {
		if (index > 0) {
			index -= 1;
		} else if (index == 0) {
			index = indexMax;
		}
	}
	
	void CursorDown () {
		if (index < indexMax) {
			index += 1;
		} else if (index == indexMax) {
			index = 0;
		}
	}
	
	void CursorSet (int newIndex) {
		index = newIndex;
	}
	
	public override void End () {
		
		base.End();
		
		Debug.Log("Unloading Title");
		SceneManager.UnloadSceneAsync("Title");
		
	}
}
