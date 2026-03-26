namespace apbd_cw2_s32640.Exceptions;

public class EquipmentUnavailableException(int id) : Exception($"Equipment with id {id} is not available");
