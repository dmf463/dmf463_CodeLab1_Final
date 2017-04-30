using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tulips : Plants {


    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        note = 0;
        Debug.Log("Growing Tulips");
        base.Grow();
    }

}
