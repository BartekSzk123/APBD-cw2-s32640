namespace apbd_cw2_s32640;

public abstract class Equipment(string name)
{
    private static int _nextId = 1;

    public int Id { get; } = _nextId++;
    public string Name { get; set; } = name;
    public EquipmentStatus Status { get; set; } = EquipmentStatus.Available;
    
}