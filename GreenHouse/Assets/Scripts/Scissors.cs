using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : UsableItem {

    public bool usingScissors = false;

    // Update is called once per frame
    void Update () {

        usingScissors = false;

    }

    public override void UseItem()
    {
        Debug.Log("Using Scissors");
        usingScissors = true;
    }

    public override void OnTriggerStayX(Collider other)
    {
        if (other.gameObject.tag == "Plant")
        {
            if (usingScissors == true)
            {
                other.SendMessage("Cut");
            }
        }
    }
}
