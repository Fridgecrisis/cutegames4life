using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInput : Trigger {

	public string[] keys;

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
			foreach (string key in keys) {
				if (Input.GetKeyDown(key)) {
					ActivateTrigger();
				}
			}
		}
		
	}
	
}
