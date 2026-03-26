namespace apbd_cw2_s32640.Exeptions;

public class EquipmentNotFound(int id) : Exception($"Equipement with id {id} not found.");
