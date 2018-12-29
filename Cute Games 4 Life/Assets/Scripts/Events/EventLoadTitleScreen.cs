using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLoadTitleScreen : Event {

	public override void RunEvent() {
		
		Game.EndCurrentState();
		Game.NewState("title");
		
	}
	
}