namespace apbd_cw2_s32640;

public class Laptop(string name, string operatingSystem, int ram) : Equipment(name)
{
    public string OperatingSystem { get; set; } = operatingSystem;
    public int Ram { get; set; } = ram;
}