using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants : Interactable {

	// Use this for initialization
	//void Start () {

 //       //base.Start();
	//}
	
	// Update is called once per frame
	void Update () {
		
	}

    //public override bool IsInteractable()
    //{
    //    return base.IsInteractable();
    //}

    public override bool IsUsable()
    {
        return false;
    }
}
