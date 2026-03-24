using APBD_TASK2.Models;

namespace APBD_TASK2.Interfaces;

public interface IRentalService
{
    void AddUser(User user);
    void AddEquipment(Equipment equipment);

    void RentEquipment(string userId, string equipmentId);
    void ReturnEquipment(string equipmentId);

    List<Equipment> GetAllEquipment();
    List<Equipment> GetAvailableEquipment();
}