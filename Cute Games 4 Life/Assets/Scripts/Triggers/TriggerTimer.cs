using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTimer : Trigger {

	public int time;

	// Use this for initialization
	public override void Start () {
		
		base.Start();
		
	}
	
	// Update is called once per frame
	public override void Update () {
		
		base.Update();
		
	}
	
	public override void UpdateTrigger () {
		
		base.UpdateTrigger();
		
		if (triggerEnabled == true) {
			time -= 1;
			if (time <= 0) {
				time = 0;
				ActivateTrigger();
			}
		}
		
	}
	
}
