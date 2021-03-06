﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflowers : Plants {

    public override void Start()
    {
        //note = 8;
        gmObj = GameObject.Find("GameManager");
        gmScript = gmObj.GetComponent<GameManager>();
        audioClip = gmScript.sounds["arpeg2"];
    }

    public override bool IsUsable()
    {
        return false;
    }

    public override void Grow()
    {
        Debug.Log("Growing Sunflowers");
        base.Grow();
        Debug.Log(name + "note is " + note);
        Debug.Log(name + "tranpose is " + transpose);
    }

}
