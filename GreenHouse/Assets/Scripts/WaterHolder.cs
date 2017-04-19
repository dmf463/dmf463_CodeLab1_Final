using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHolder : UsableItem {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void UseItem()
    {
        Debug.Log("Using WaterHolder");
    }
}
