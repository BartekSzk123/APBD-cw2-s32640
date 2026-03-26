using apbd_cw2_s32640.Exeptions;

namespace apbd_cw2_s32640.Service;

public class EquipmentService : IEquipmentService
{
    
    private readonly List<Equipment> _equipments = [];
    public void addEquipment(Equipment equipment)
    {
        _equipments.Add(equipment);
    }

    public Equipment getEquipemntById(int id)
    {
        return _equipments.FirstOrDefault(equipemnt => equipemnt.Id == id) 
               ?? throw new EquipmentNotFound(id);
    }

    public List<Equipment> getAllEquipments()
    {
        return _equipments;
    }

    public List<Equipment> getAvailable()
    {
        return _equipments.Where(equipemnt => equipemnt.Status == EquipmentStatus.Available).ToList();
    }

    public void setAvailable(int id)
    {
        getEquipemntById(id).Status = EquipmentStatus.Available;
    }

    public void setUnavailable(int id)
    {
        getEquipemntById(id).Status = EquipmentStatus.Available;
    }
}