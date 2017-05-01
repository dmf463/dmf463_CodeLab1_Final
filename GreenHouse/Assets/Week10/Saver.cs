using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour {

	void Start ()
    {
        // Declare a new PlantManager.
        PlantManager pm = new PlantManager();

        // Go through all asteroids in the scene.
		foreach(GameObject plants in GameObject.FindGameObjectsWithTag("Plant"))
        {
            pm.SavePlant(plants);
        }

        pm.WriteArray();
	}
}
