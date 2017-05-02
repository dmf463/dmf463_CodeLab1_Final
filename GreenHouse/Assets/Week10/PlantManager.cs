using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class PlantManager {

    JSONArray plantArray;


    public PlantManager()
    {
        plantArray = new JSONArray();
    }


	public void SavePlant(GameObject plant)
    {
        // 1: Create plant data for this plant.
        //Debug.Log(plant.gameObject.name);
        PlantData pd = new PlantData(plant.transform.position, plant.transform.localScale, plant.gameObject.name);

        // 2: Add plant data to plantArray as JSONClass
        plantArray.Add(pd.ToJSON());
        Debug.Log(plantArray);
    }


    public void WriteArray()
    {
        UtilScript.WriteJSONtoFile(Application.dataPath, "SavedPlants.txt", plantArray);
    }


    public PlantData[] ReadPlants()
    {
        // Read array from file.
        plantArray = UtilScript.ReadJSONFromFile(Application.dataPath, "SavedPlants.txt") as JSONArray;

        PlantData[] plantDatas = new PlantData[plantArray.Count];

        for (int i = 0; i < plantArray.Count; i++)
        {
            plantDatas[i] = new PlantData(plantArray[i] as JSONClass);
        }

        return plantDatas;
    }
}
