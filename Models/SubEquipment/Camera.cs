namespace APBD_TASK2.Models
{
    public class Camera : Equipment
    {
        private int pixels { get; set; }
        private bool isBroken { get; set; }

        public Camera(string name, int megapixels, bool hasLens)
            : base(name)
        {
            this.pixels = pixels;
            this.isBroken = isBroken;
        }
    }