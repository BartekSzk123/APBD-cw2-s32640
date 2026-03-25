namespace apbd_cw2_s32640.Service;

public interface IEquipmentService
{
    public void addEquipment(Equipment equipment);
    public Equipment getEquipemntById(int id);
    public List<Equipment> getAllEquipments();
    public List<Equipment> getAvailable();
    public void setAvailable(int id);
    public void setUnavailable(int id);
}