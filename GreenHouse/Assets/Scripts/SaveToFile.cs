using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveToFile : MonoBehaviour {

    public string SaveFileName;
    public static SaveToFile instance;

	// Use this for initialization
	void Start () {

        if (instance == null)
        {
            //set instance to this instance of ScoreManager
            instance = this;
            //Dont destroy this gameObject when you go to a new scene
            DontDestroyOnLoad(this);
        }
        else
        { //otherwise, if we already have a singleton
          //Destroy the new one, since there can only be one
            Destroy(gameObject);
        }

    }
	
	// Update is called once per frame
	void Update () {

    }
}
