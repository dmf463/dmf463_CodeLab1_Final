﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    protected GameObject gmObj;
    protected GameManager gmScript;

    // Use this for initialization
    public virtual void Start () {

        gmObj = GameObject.Find("GameManager");
        gmScript = gmObj.GetComponent<GameManager>();
        Debug.Log(gmObj);
    }
	
	// Update is called once per frame
	public virtual void Update () {

        this.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
		
	}

    //public virtual bool IsInteractable()
    //{
    //    return true;
    //}

    public virtual bool IsUsable()
    {
        return true;
    }

    public virtual void AttachToHand(GameObject other)
    {
        //hand = GameObject.FindGameObjectWithTag("hand");
        //Debug.Log("the hand is called " + hand.name);
        //Debug.Log("Clicking on: " + other.gameObject.name);
        other.GetComponent<Rigidbody>().isKinematic = true;
        other.transform.parent = Camera.main.transform;
        other.tag = "heldItem";
        gmScript.isHolding = true;
        //other.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        //other.transform.localPosition = new Vector3(0, 0, 0);
        //other.transform.localPosition = UtilScript.CloneModVector3(other.transform.localPosition, xMod, yMod, zMod);
    }

    public virtual void DetachFromHand(GameObject other)
    {
        other.GetComponent<Rigidbody>().isKinematic = false;
        other.transform.parent = null;
        if (other.tag == "Plant")
        {
            other.tag = "Plant";
            other.transform.parent = GameObject.Find("Pots").transform;
        }
        else
        {
            other.tag = "Untagged";
        }
    }
}
