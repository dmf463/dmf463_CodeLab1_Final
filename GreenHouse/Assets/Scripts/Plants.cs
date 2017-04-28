using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants : Interactable {

    GameObject plant;
	
	// Update is called once per frame
	void Update () {
		
	}


    public override bool IsUsable()
    {
        return false;
    }

    public void Grow()
    {
        Debug.Log("Plant is Growing");
        plant = transform.GetChild(0).gameObject;
        plant.transform.position += new Vector3(0, 0.1f, 0);
        plant.transform.localScale += new Vector3(0, 0.15f, 0);
    }

    public void Cut()
    {
        Debug.Log("Plant is Cut!");
        plant = transform.GetChild(0).gameObject;
        plant.transform.position -= new Vector3(0, 0.1f, 0);
        plant.transform.localScale -= new Vector3(0, 0.15f, 0);
    }
}
