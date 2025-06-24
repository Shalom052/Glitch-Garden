public class Plant
{
    public string Name { get; private set; }
    public bool IsHealthy { get; private set; }
    public string CurrentGlitch { get; private set; }

    public Plant(string name, bool isHealthy, string currentGlitch)
    {
        Name = name;
        IsHealthy = isHealthy;
        CurrentGlitch = currentGlitch;
    }

    public void DebugPlant()
    {
        IsHealthy = true; // Fix the glitch
    }
}
