using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool isHolding;
    public float distanceBetween;
    public GameObject player;
    const float DISTANCE_THRESHOLD = 2f;

	// Use this for initialization
	void Start () {

        isHolding = false;

    }
	
	// Update is called once per frame
	void Update () {

        Cursor.lockState = CursorLockMode.Locked;

        RaycastHit rayhit;

        Debug.Log("is holding = " + isHolding);

        if (Input.GetMouseButtonDown(0))
        {
            if (isHolding == false && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayhit))
            {
                distanceBetween = Vector3.Distance(player.transform.position, rayhit.transform.position);
                if( distanceBetween < DISTANCE_THRESHOLD)
                {
                    Debug.Log("hitting " + rayhit.collider.gameObject.name);
                    rayhit.rigidbody.isKinematic = true;
                    rayhit.transform.parent = Camera.main.transform;
                    isHolding = true;
                }
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
