using System.Collections.Generic;

namespace GlitchGarden
{
    public class LevelManager
    {
        public Level CurrentLevel { get; private set; }

        public LevelManager()
        {
            // Setup Level 1: "Debug Grove" with dying plants needing code fixes
            CurrentLevel = new Level(1, "Debug Grove", "Meadow", 3);

            // Realistic plants with "buggy code" to fix
            CurrentLevel.AddPlant(new Plant(
                "Rose", 
                false, 
                "PhotosynthesisError: Light absorption module not responding;"
            ));
            
            CurrentLevel.AddPlant(new Plant(
                "Tulip", 
                false, 
                "GrowthFunction() missing return value for stemHeight;"
            ));
            
            CurrentLevel.AddPlant(new Plant(
                "Sunflower", 
                false, 
                "ColorShaderException: Petal color undefined; expected 'Yellow'; found 'Null';"
            ));
        }
    }
}
