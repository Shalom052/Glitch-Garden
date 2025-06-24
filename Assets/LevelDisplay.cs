using UnityEngine;
using TMPro;
using GlitchGarden;

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI plantText;
    private LevelManager levelManager;

    void Start()
    {
        levelManager = new LevelManager();

        plantText.text = "Level " + levelManager.CurrentLevel.LevelNumber + ": " + levelManager.CurrentLevel.LevelName + "\n";
        plantText.text += "Biome: " + levelManager.CurrentLevel.BiomeName + "\n\n";
        plantText.text += "Plants:\n";

        foreach (Plant plant in levelManager.CurrentLevel.LevelPlants)
        {
            string status = plant.IsHealthy ? "Healthy 🌸" : "Glitched ❌ (" + plant.CurrentGlitch + ")";
            plantText.text += plant.Name + " - " + status + "\n";
        }
    }
}


