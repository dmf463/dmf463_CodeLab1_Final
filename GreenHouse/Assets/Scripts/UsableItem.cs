using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableItem : Interactable {

	// Use this for initialization
	//void Start () {
 //       base.Start();
	//}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override bool IsUsable()
    {
        return base.IsUsable();
    }

    public virtual void UseItem()
    {
        Debug.Log("UseItem");
    }
}
