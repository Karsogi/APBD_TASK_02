using APBD_TASK2.Interfaces;
using APBD_TASK2.Models;

namespace APBD_TASK2.Services;

public class RentalService : IRentalService
{
    private List<User> users = new();
    private List<Equipment> equipment = new();
    private List<Rental> rentals = new();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AddEquipment(Equipment eq)
    {
        equipment.Add(eq);
    }

    public List<Equipment> GetAllEquipment() => equipment;

    public List<Equipment> GetAvailableEquipment()
    {
        return equipment.Where(e => e.IsAvailable).ToList();
    }

    public void RentEquipment(string userId, string equipmentId)
    {
        var user = users.FirstOrDefault(u => u.Id == userId);
        var eq = equipment.FirstOrDefault(e => e.Id == equipmentId);

        if (user == null || eq == null)
            throw new Exception("User or Equipment not found");

        if (!eq.IsAvailable)
            throw new Exception("Equipment not available");

        int active = rentals.Count(r => r.User.Id == userId && !r.IsReturned);

        if (active >= user.MaxActiveRentals)
            throw new Exception("User exceeded rental limit");

        rentals.Add(new Rental
        {
            User = user,
            Equipment = eq,
            RentDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(7)
        });

        eq.IsAvailable = false;
    }

    public void ReturnEquipment(string equipmentId)
    {
        var rental = rentals.FirstOrDefault(r =>
            r.Equipment.Id == equipmentId && !r.IsReturned);

        if (rental == null)
            throw new Exception("Rental not found");

        rental.ReturnDate = DateTime.Now;
        rental.Equipment.IsAvailable = true;

        if (rental.ReturnDate > rental.DueDate)
        {
            Console.WriteLine("Late return! Penalty applied.");
        }
    }
}