using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnObject : MonoBehaviour {

    bool isHolding;
   
	// Use this for initialization
	void Start () {

        isHolding = false;
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit rayhit;

        Debug.Log("is holding = " + isHolding);

        if (Input.GetMouseButtonDown(0))
        {
            if (isHolding == false && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayhit))
            {
                Debug.Log("hitting " + rayhit.collider.gameObject.name);
                rayhit.rigidbody.isKinematic = true;
                rayhit.transform.parent = Camera.main.transform;
                isHolding = true;
            }
            else if (isHolding == true)
            {
                isHolding = false;
                Camera.main.transform.GetChild(0).GetComponent<Rigidbody>().isKinematic = false;
                Camera.main.transform.GetChild(0).transform.parent = null;
            }
        }

        
		
	}
}
