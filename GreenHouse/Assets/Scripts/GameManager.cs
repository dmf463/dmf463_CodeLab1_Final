using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;

    //void OnMouseEnter()
    //{
    //    Cursor.SetCursor(null, hotSpot, cursorMode);
    //}

	// Use this for initialization
	void Start () {

        //OnMouseEnter();
        //Cursor.visible = true;

    }
	
	// Update is called once per frame
	void Update () {


        Cursor.lockState = CursorLockMode.Locked;


    }
}
