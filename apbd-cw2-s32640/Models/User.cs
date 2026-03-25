using System.Runtime.Versioning;

namespace apbd_cw2_s32640;

public abstract class User(string fName, string lName)
{
    private static int _nextId = 1;
    
    public int Id { get; } =  _nextId++;
    public string Name { get; set; } = fName;
    public string LastName { get; set; } = lName;

    public abstract int GetNumberOfRentedItems();
}