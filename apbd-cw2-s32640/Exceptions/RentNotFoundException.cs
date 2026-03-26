namespace apbd_cw2_s32640.Exceptions;

public class RentNotFoundException(int id) : Exception($"There is no rent under {id} id");