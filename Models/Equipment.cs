namespace APBD_TASK2.Models;

public abstract class Equipment
{
    public static int _id = 1;

    public string Id { get; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }

    public Equipment(string name)
    {
        Id = _id.ToString();
        _id++;
        Name = name;
        IsAvailable = true;
    }
}