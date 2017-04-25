using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants : Interactable {
	
	// Update is called once per frame
	void Update () {
		
	}


    public override bool IsUsable()
    {
        return false;
    }

    public void Grow()
    {
        Debug.Log("Plant is Growing");
    }

    public void Cut()
    {
        Debug.Log("Plant is Cut!");
    }
}
