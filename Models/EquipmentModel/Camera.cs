namespace APBD_TASK2.Models.EquipmentModel;

public class Camera : Equipment
{
    public int pixels { get; set; }
    public bool working { get; set; }

    public Camera(int pixels, bool working)
        : base("Camera")
    {
        this.pixels = pixels;
        this.working = working;
    }
}