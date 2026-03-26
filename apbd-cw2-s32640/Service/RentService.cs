using apbd_cw2_s32640.Exceptions;

namespace apbd_cw2_s32640.Service;

public class RentService : IRentService
{
    
    private readonly List<Rent> _rents;
    
    public void CreateRent(User user, Equipment equipment, DateTime from, DateTime to)
    {
        if (equipment.Status != EquipmentStatus.Available)
        {
            throw new EquipmentUnavailableException(equipment.Id);
        }
        
        int activeUserRents = _rents.Count(rent => rent.IsActive && rent.User.Id == user.Id);

        if (activeUserRents >= user.GetNumberOfRentedItems())
        {
            throw new TooManyRentedItemsException(user.Id);
        }
        
        var newRent = new Rent(equipment, user, from, to);
        _rents.Add(newRent);
        
    }

    public void RetrunRent(int rentId, DateTime returnedDate)
    {
        var rent = _rents.FirstOrDefault(rent => rent.Id == rentId);
        if (rent == null)
        {
            throw new RentNotFoundException(rentId);
        }
        
        rent.Return(returnedDate);
    }

    public List<Rent> GetUserRent(int userId)
    {
        return _rents.Where(rent => rent.User.Id == userId && rent.IsActive).ToList();
    }

    public List<Rent> GetOverdueRents()
    {
        return _rents.Where(rent => rent.IsOverdue).ToList();
    }

    public List<Rent> GetAll()
    {
        return _rents;
    }
}