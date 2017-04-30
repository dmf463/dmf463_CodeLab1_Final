using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflowers : Plants {

    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        base.note = 1;
        Debug.Log("Growing Tulips");
        base.Grow();
    }

}
