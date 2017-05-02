using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lily : Plants {

    public override void Start()
    {
        //note = 0;
        gmObj = GameObject.Find("GameManager");
        gmScript = gmObj.GetComponent<GameManager>();
        audioClip = gmScript.sounds["arpeg3"];
    }

    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        //note = 0;
        Debug.Log("Growing Lilies");
        base.Grow();
        //Debug.Log(name + "note is " + note);
        //Debug.Log(name + "tranpose is " + transpose);
    }

}
