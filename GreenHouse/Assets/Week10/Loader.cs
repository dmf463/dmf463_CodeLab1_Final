using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    void Start()
    {
        PlantManager pm = new PlantManager();

        PlantData[] plantDatas = pm.ReadPlants();

        // Instantiate all asteroids from asteroidDatas.
        foreach(PlantData pd in plantDatas)
        {
            GameObject newPlant = Instantiate(Resources.Load("Prefabs/Pot")) as GameObject;
            newPlant.transform.position = pd.position;
            newPlant.transform.localScale = pd.scale;
            newPlant.gameObject.name = pd.name;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
