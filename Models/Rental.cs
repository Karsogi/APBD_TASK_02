namespace APBD_TASK2.Models;

public class Rental
{
    public User User { get; set; }
    public Equipment Equipment { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public bool IsReturned => ReturnDate != null;
}