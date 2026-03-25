namespace apbd_cw2_s32640;

public class Rent(Equipment equipment, User user, DateTime from, DateTime to)
{
    private static int _nextId = 1;

    public int Id { get; } = _nextId++;
    public Equipment Equipment { get; set; } = equipment;
    public User User { get; set; } = user;
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public DateTime? ReturnedDate { get; private set; }

    public bool IsReturnedOnTime => ReturnedDate <= to && ReturnedDate != null;
    public bool IsOverdue => ReturnedDate == null && DateTime.Now > To;
    public bool IsActive => ReturnedDate == null;

    public double Penalty { get; private set; }

    public void Return(DateTime returnedDate)
    {
        ReturnedDate = returnedDate;

        if (ReturnedDate > To)
        {
            var daysLater = (returnedDate - To).Days;
            Penalty = 5 * daysLater;
        }
    }
}