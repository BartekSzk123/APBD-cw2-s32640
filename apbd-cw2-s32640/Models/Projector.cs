namespace apbd_cw2_s32640;

public class Projector(string name, bool hasBluetooth, int lumens) : Equipment(name)
{
    public bool HasBluetooth { get; } = hasBluetooth;
    public int Lumens { get; } = lumens;
}