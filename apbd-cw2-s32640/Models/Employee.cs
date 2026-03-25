namespace apbd_cw2_s32640;

public class Employee(string fname, string lName) : User(fname, lName)
{
    public override int GetNumberOfRentedItems() => 5;
}