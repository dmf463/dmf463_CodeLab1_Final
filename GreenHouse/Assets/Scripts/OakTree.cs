using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OakTree : Plants {

    public override void Start()
    {
        //note = 0;
        gmObj = GameObject.Find("GameManager");
        gmScript = gmObj.GetComponent<GameManager>();
        audioClip = gmScript.sounds["spaceHook"];
    }

    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        //note = 0;
        Debug.Log("Growing Oak Trees");
        base.Grow();
    }

}