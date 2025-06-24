using UnityEngine;
using TMPro;
using GlitchGarden;

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI levelInfoText; // Assign this in Inspector
    private LevelManager levelManager;

    void Start()
    {
        levelManager = new LevelManager(); // Create Level 1 backend

        // Prepare UI display string
        string info = "LEVEL " + levelManager.CurrentLevel.LevelNumber +
                      ": " + levelManager.CurrentLevel.LevelName +
                      "\nBiome: " + levelManager.CurrentLevel.BiomeName +
                      "\nTarget Score: " + levelManager.CurrentLevel.TargetScore;

        // Show this info in the UI
        levelInfoText.text = info;
    }
}



