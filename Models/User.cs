using APBD_TASK2.Enum;

namespace APBD_TASK2.Models;

public class User
{
    private static int _nextId = 1;

    public string Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public UserType Type { get; }

    public int MaxActiveRentals => Type switch
    {
        UserType.Student => 2,
        UserType.Employee => 5,
        _ => 0
    };

    public User(string name, string surname, UserType type)
    {
        Id = _nextId.ToString();
        _nextId++;

        Name = name;
        Surname = surname;
        Type = type;
    }
}