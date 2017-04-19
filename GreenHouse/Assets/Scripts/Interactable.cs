﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    GameObject hand;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual bool IsInteractable()
    {
        return true;
    }

    public virtual bool IsUsable()
    {
        return true;
    }

    public virtual void AttachToHand(GameObject other)
    {
        hand = GameObject.FindGameObjectWithTag("hand");
        //Debug.Log("the hand is called " + hand.name);
        //Debug.Log("Clicking on: " + other.gameObject.name);
        other.GetComponent<Rigidbody>().isKinematic = true;
        other.transform.parent = hand.transform;
        other.tag = "heldItem";
        //other.transform.localPosition = new Vector3(0, 0, 0);
        //other.transform.localPosition = UtilScript.CloneModVector3(other.transform.localPosition, xMod, yMod, zMod);
    }

    public virtual void DetachFromHand(GameObject other)
    {
        other.GetComponent<Rigidbody>().isKinematic = false;
        other.transform.parent = null;
        other.tag = "Untagged";
    }
}