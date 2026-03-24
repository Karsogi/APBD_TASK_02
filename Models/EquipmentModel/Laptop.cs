namespace APBD_TASK2.Models.EquipmentModel;

public class Laptop : Equipment
{
    private String model { get; set; }
    public Laptop(String model)
        :base("Laptop")
        {
            this.model = model;
        }
}