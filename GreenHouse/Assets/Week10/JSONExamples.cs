using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class JSONExamples : MonoBehaviour {



	// Use this for initialization
	void Start () {

		//A JSONArray can hold several JSONClass objects, just like a regular array
		JSONArray jArray = new JSONArray();

		//JSONNode is a super class to both JSONNode and JSONArray!
		//That means you can pass JSONArrays and JSONClasses anywhere you use JSONNodes!

		JSONNode testNode1 = new JSONClass(); //Create a new JSONClass
		testNode1["x"].AsFloat = 10f; //Add a value to it

		JSONNode testNode2 = new JSONClass(); //Create a new JSONClass
		testNode2["x"].AsFloat = 2f; //Add a value to it

		JSONNode testNode3 = new JSONClass(); //Create a new JSONClass
		testNode3["x"].AsFloat = 8.435f; //Add a value to it

		jArray.Add(testNode1); //Add JSONClass to jArray
		jArray.Add(testNode2); //Add JSONClass to jArray
		jArray.Add(testNode3); //Add JSONClass to jArray

		print(jArray); //print out jArray with all 3 JSONObjects as part of it
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
