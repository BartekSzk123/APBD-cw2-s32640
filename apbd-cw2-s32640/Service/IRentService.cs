namespace apbd_cw2_s32640.Service;

public interface IRentService
{
    public void CreateRent(User user,Equipment equipment,DateTime from , DateTime to);
    public void RetrunRent(int rentId,DateTime returnedDate);
    public List<Rent> GetUserRent(int userId);
    public List<Rent> GetAll();
    public List<Rent> GetOverdueRents();
}