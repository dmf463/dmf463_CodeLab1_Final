using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    void Start()
    {

        PlantManager pm = new PlantManager();

        PlantData[] plantDatas = pm.ReadPlants();

        if(pm.SaveFileName == null)
        {
            return;
        }
        else
        {
            GameObject[] planstToKill = GameObject.FindGameObjectsWithTag("Plant");
            for (int i = 0; i < planstToKill.Length; i++)
            {
                Destroy(planstToKill[i]);
            }
        }

        // Instantiate all asteroids from asteroidDatas.
        foreach (PlantData pd in plantDatas)
        {
            GameObject newPlant = Instantiate(Resources.Load("Prefabs/Pot")) as GameObject;
            newPlant.transform.position = pd.position;
            newPlant.transform.localScale = pd.scale;
            newPlant.gameObject.name = pd.name;
            switch (pd.name)
            {
                case "Tulips":
                    newPlant.AddComponent<Tulips>();
                    break;
                case "Sunflowers":
                    newPlant.AddComponent<Sunflowers>();
                    break;
                case "Gardenias":
                    newPlant.AddComponent<Gardenias>();
                    break;
                case "Orchid":
                    newPlant.AddComponent<Orchid>();
                    break;
                case "Lily":
                    newPlant.AddComponent<Lily>();
                    break;
                case "PalmTree":
                    newPlant.AddComponent<PalmTree>();
                    break;
                case "OakTree":
                    newPlant.AddComponent<OakTree>();
                    break;
                case "Corn":
                    newPlant.AddComponent<Corn>();
                    break;
                case "Octopus":
                    newPlant.AddComponent<Octopus>();
                    break;
                case "Arm":
                    newPlant.AddComponent<Arm>();
                    break;
                case "Roses":
                    newPlant.AddComponent<Roses>();
                    break;
                default:
                    break;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
