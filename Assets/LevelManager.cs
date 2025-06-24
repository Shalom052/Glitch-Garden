using System.Collections.Generic;

namespace GlitchGarden
{
    public class LevelManager
    {
        public Level CurrentLevel { get; private set; }

        public LevelManager()
        {
            // Create Level 1
            CurrentLevel = new Level(1, "Debug Grove", "Neon Forest", 100);

            // Add some plants to this level
            CurrentLevel.AddPlant(new Plant("Rosebyte", true, ""));
            CurrentLevel.AddPlant(new Plant("Glitchvine", false, "Texture Missing"));
            CurrentLevel.AddPlant(new Plant("Databud", false, "Overgrowth Error"));
        }

        public bool IsLevelComplete()
        {
            return CurrentLevel.CheckCompletion();
        }
    }
}

