using UnityEngine;
using GlitchGarden;

public class PlantSpawner : MonoBehaviour
{
    public GameObject plantPrefab; // Assign this in the Inspector (drag your PlantPrefab here)

    private LevelManager levelManager;

    void Start()
    {
        levelManager = new LevelManager(); // Create level data (plants list etc.)

        float xOffset = -3f;   // Starting x position for the first plant
        float xSpacing = 2.5f; // Space between each plant

        // Spawn each plant listed in LevelManager's CurrentLevel
        foreach (Plant plant in levelManager.CurrentLevel.LevelPlants)
        {
            // Instantiate a plant prefab at the position
            GameObject plantGO = Instantiate(plantPrefab, new Vector3(xOffset, 0, 0), Quaternion.identity);

            // Get the PlantBehaviour script from the spawned plant
            PlantBehaviour pb = plantGO.GetComponent<PlantBehaviour>();

            // Assign the plant data to the PlantBehaviour
            pb.myPlant = plant; // <<< THIS FIXES your "Plant data not assigned" warning!

            xOffset += xSpacing; // Move x position for the next plant
        }
    }
}
