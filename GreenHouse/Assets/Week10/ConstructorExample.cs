using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorExample {

	public float temp;
	public string name;
	public GameObject gameObject;
	public int mattParker;
	public bool isCool;
	public Wk10Manager manager;

	//Empty Constructor
	public ConstructorExample(){
		Debug.Log("Made a Loader");

		temp = 10;
		name = "No Name";
		mattParker = 11;
		isCool = false;
	}

	public ConstructorExample(float temp, string name){
		this.temp = temp;
		this.name = name;
	}
}
