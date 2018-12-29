using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	//public string type;
	public bool triggerEnabled = true;
	public List<Event> eventList;

	// Use this for initialization
	public virtual void Start () {
		
		// To be extended by children.
		
	}
	
	// Update is called once per frame
	public virtual void Update () {
		
		// To be extended by children.
		
	}
	
	public virtual void UpdateTrigger () {
		
		// To be extended by children.
		
	}
	
	public void ActivateTrigger () {
		
		if (triggerEnabled == true) {
			foreach (Event triggerEvent in eventList) {
				Game.game.eventHandler.RunEvent(triggerEvent);
			}
			DisableTrigger();
		}
		
	}
	
	public void EnableTrigger () {
		
		triggerEnabled = true;
		
	}
	
	public void DisableTrigger () {
		
		triggerEnabled = false;
		
	}
	
}
