using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour {

	void Start ()
    {
        // Declare a new AsteroidManager.
        AsteroidManager am = new AsteroidManager();

        // Go through all asteroids in the scene.
		foreach(GameObject asteroid in GameObject.FindGameObjectsWithTag("Asteroid"))
        {
            am.SaveAsteroid(asteroid);
        }

        am.WriteArray();
	}
}
