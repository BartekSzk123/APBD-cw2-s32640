namespace apbd_cw2_s32640.Exceptions;

public class TooManyRentedItemsException(int id) : Exception($"There is too many rented items for user {id}");
