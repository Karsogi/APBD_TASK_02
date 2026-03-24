using APBD_TASK2.Models;

public class Laptop : Equipment
{
    private string Processor { get; set; }
    private int RAM { get; set; }

    public Laptop(string name, string processor, int ram)
        : base("Laptop")
    {
        Processor = processor;
        RAM = ram;
    }
}