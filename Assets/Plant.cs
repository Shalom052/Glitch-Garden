namespace GlitchGarden
{
    public class Plant
    {
        public string Name { get; set; }
        public bool IsHealthy { get; set; }
        public string CurrentGlitch { get; set; }

        public Plant(string name, bool isHealthy, string currentGlitch)
        {
            Name = name;
            IsHealthy = isHealthy;
            CurrentGlitch = currentGlitch;
        }
    }
}
