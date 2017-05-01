using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tulips : Plants {

    public override void Start()
    {
        //note = 0;
        gmObj = GameObject.Find("GameManager");
        gmScript = gmObj.GetComponent<GameManager>();
        audioClip = gmScript.sounds["hornNote"];
    }

    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        //note = 0;
        Debug.Log("Growing Tulips");
        base.Grow();
        Debug.Log(name + "note is " + note);
        Debug.Log(name + "tranpose is " + transpose);
    }

}
