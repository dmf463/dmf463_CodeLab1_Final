using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHolder : UsableItem {

    public bool usingWater = false;
    float note;

	void Update () {

        Debug.Log("usingWater = " + usingWater);
        usingWater = false;
	}

    public override void UseItem()
    {
        Debug.Log("Using WaterHolder");
        usingWater = true;
    }

    public override void OnTriggerStayX(Collider other)
    {
        if (other.gameObject.tag == "Plant")
        {
            if (usingWater == true)
            {
                other.SendMessage("Grow");
            }
        }
    }

}
