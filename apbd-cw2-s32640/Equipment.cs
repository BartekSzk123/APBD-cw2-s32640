namespace apbd_cw2_s32640;

public abstract class Equipment
{
    private static int _nextId = 0;

    public int Id { get; }
    public string Name { get; set; }
    public EquipemntStatus Status { get; set; }


    public Equipment(int id, string name, EquipemntStatus status)
    {
        Id = _nextId++;
        Name = name;
        Status = status;
    }
}