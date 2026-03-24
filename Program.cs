

using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Models;
using APBD_TASK2.Services;

var db = Singleton.Instance;

var service = new RentalService();
var student = new User("John", "Smith", UserType.Student);
var employee = new User("Anna", "Nowak", UserType.Employee);

service.AddUser(student);
service.AddUser(employee);

var laptop = new Equipment("Laptop");
var camera = new Equipment("Camera");

service.AddEquipment(laptop);
service.AddEquipment(camera);

service.RentEquipment(student.Id, laptop.Id);

try
{
    service.RentEquipment(student.Id, camera.Id);
    service.RentEquipment(student.Id, new Equipment("Extra").Id);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

service.ReturnEquipment(laptop.Id);
foreach (var e in service.GetAllEquipment())
{
    Console.WriteLine($"{e.Name} available: {e.IsAvailable}");
}