

using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Models;
using APBD_TASK2.Models.EquipmentModel;
using APBD_TASK2.Services;

var db = Singleton.Instance;

var service = new RentalService();
var student = new User("John", "Smith", UserType.Student);
var employee = new User("Anna", "Nowak", UserType.Employee);

service.AddUser(student);
service.AddUser(employee);

var laptop = new Laptop("ASUS");
var camera = new Camera(4800,true);

service.AddEquipment(laptop);
service.AddEquipment(camera);

service.RentEquipment(student.Id, laptop.Id);

try
{
    service.RentEquipment(student.Id, camera.Id);
    service.RentEquipment(student.Id, laptop.Id);
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
service.RentEquipment(employee.Id, camera.Id);
var rental = service.GetAllRentals().First(r => r.Equipment.Id == camera.Id);
rental.DueDate = DateTime.Now.AddDays(-5);
service.ReturnEquipment(camera.Id);
Console.WriteLine("Program has finished");