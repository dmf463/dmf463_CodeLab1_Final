using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gardenias : Plants {

    public override void Start()
    {
        //note = 0;
        gmObj = GameObject.Find("GameManager");
        gmScript = gmObj.GetComponent<GameManager>();
        audioClip = gmScript.sounds["organC2"];
    }

    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        //note = 0;
        Debug.Log("Growing Gardenias");
        base.Grow();
    }

}