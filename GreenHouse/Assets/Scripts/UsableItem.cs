using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableItem : Interactable {


	void Update () {
		
	}

    public void OnTriggerStay(Collider other)
    {
        OnTriggerStayX(other);
    }

    public virtual void OnTriggerStayX(Collider other)
    {
        if (other.gameObject.tag == "Plant")
        {
            other.SendMessage("TouchingPlant");
        }
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
