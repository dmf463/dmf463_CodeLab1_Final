using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalmTree : Plants {

    public override void Start()
    {
        //note = 0;
        gmObj = GameObject.Find("GameManager");
        gmScript = gmObj.GetComponent<GameManager>();
        audioClip = gmScript.sounds["organCM"];
    }

    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        //note = 0;
        Debug.Log("PalmTree");
        base.Grow();
    }

}
