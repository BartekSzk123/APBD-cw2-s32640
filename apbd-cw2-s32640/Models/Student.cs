namespace apbd_cw2_s32640;

public class Student(string fname, string lName) : User(fname, lName)
{
    public override int GetNumberOfRentedItems() => 2;
}