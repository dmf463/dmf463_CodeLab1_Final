using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    GameObject hand;


    // Use this for initialization
    void Start () {

        hand = GameObject.Find("RightHand");

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

    public virtual void AttachToHand(Transform other)
    {
        other.parent = hand.transform;
    }
}
