using UnityEngine;
using GlitchGarden;

public class PlantBehaviour : MonoBehaviour
{
    public Plant myPlant; // This gets assigned in PlantSpawner.cs
    private SpriteRenderer spriteRenderer; // Renamed to avoid conflict with Unity's built-in 'renderer'

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get this GameObject's SpriteRenderer
    }

    private void OnMouseDown() // Called when the plant is clicked
    {
        if (myPlant != null) // Always check to prevent null errors
        {
            myPlant.DebugPlant(); // Mark the plant as debugged (healthy)
            spriteRenderer.color = Color.green; // Change its color to green when debugged

            // OPTIONAL: Stop glitch particles (if your prefab has them)
            ParticleSystem glitchParticles = GetComponentInChildren<ParticleSystem>();
            if (glitchParticles != null)
            {
                glitchParticles.Stop(); // Stop the particle effect
            }
        }
        else
        {
            Debug.LogWarning("Plant data not assigned to this PlantBehaviour!");
        }
    }
}
