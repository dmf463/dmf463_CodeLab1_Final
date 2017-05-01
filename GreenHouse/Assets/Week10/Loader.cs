using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    void Start()
    {
        AsteroidManager am = new AsteroidManager();

        AsteroidData[] asteroidDatas = am.ReadAsteroids();

        // Instantiate all asteroids from asteroidDatas.
        foreach(AsteroidData ad in asteroidDatas)
        {
            GameObject newAsteroid = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            newAsteroid.transform.position = ad.position;
            newAsteroid.transform.localScale = ad.scale;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
