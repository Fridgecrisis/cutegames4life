using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour {

	//public List<Event> eventList;

	// Use this for initialization
	public void Start () {
		
		/* foreach (Transform child in transform) {
			eventList.Add(child.gameObject.GetComponent<Event>());
		} */
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void RunEvent (Event triggerEvent) {
		
		triggerEvent.RunEvent();
		/* for (int i = 0; i < eventList.Count; i++) {
			if (eventList[i].eventID == eventID) {
				eventList[i].RunEvent();
			}
		} */
		
	}
	
}
