using System.Collections.Generic;

namespace GlitchGarden
{
    public class Level
    {
        public int LevelNumber { get; private set; }
        public string LevelName { get; private set; }
        public string BiomeName { get; private set; }
        public List<Plant> LevelPlants { get; private set; }
        public int TargetScore { get; private set; }
        public bool IsCompleted { get; private set; }

        public Level(int levelNumber, string levelName, string biomeName, int targetScore)
        {
            LevelNumber = levelNumber;
            LevelName = levelName;
            BiomeName = biomeName;
            TargetScore = targetScore;
            IsCompleted = false;
            LevelPlants = new List<Plant>();
        }

        public void AddPlant(Plant plant)
        {
            LevelPlants.Add(plant);
        }

        public bool CheckCompletion()
        {
            foreach (var plant in LevelPlants)
            {
                if (!plant.IsHealthy)
                    return false; // If even one plant is glitched, level not complete
            }
            IsCompleted = true; // All plants healthy
            return true;
        }
    }
}
