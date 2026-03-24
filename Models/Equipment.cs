namespace APBD_TASK2.Models;

public abstract class Equipment
{
    private static int _id = 1;

    private string Id { get; }
    private string Name { get; set; }
    private bool IsAvailable { get; set; }

    public Equipment(string name)
    {
        Id = _id.ToString();
        _id++;
        Name = name;
        IsAvailable = true;
    }
}