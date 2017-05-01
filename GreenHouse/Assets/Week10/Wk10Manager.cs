using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wk10Manager : MonoBehaviour {

	ConstructorExample myLoader;

	// Use this for initialization
	void Start () {
		myLoader = new ConstructorExample(0.123f, "Hi");
		myLoader.manager = this;

		print(myLoader.name);

		print(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
