using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class PlantManager {

    JSONArray plantArray;
    public string SaveFileName;


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
        SaveFileName = GameObject.Find("SaveFileName").GetComponent<SaveToFile>().SaveFileName;
        UtilScript.WriteJSONtoFile(Application.dataPath, SaveFileName, plantArray);
    }


    public PlantData[] ReadPlants()
    {
        // Read array from file.

        SaveFileName = GameObject.Find("SaveFileName").GetComponent<SaveToFile>().SaveFileName;
        plantArray = UtilScript.ReadJSONFromFile(Application.dataPath, SaveFileName) as JSONArray;

        PlantData[] plantDatas = new PlantData[plantArray.Count];

        for (int i = 0; i < plantArray.Count; i++)
        {
            plantDatas[i] = new PlantData(plantArray[i] as JSONClass);
        }

        return plantDatas;
    }
}
