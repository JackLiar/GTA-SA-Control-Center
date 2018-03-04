namespace ControlCenter.Locations.Models
{
    public class Coordinate
    {
        public float Angle;
        public float X;
        public float Y;
        public float Z;

        public Coordinate(float x, float y, float z, float angle)
        {
            X = x;
            Y = y;
            Z = z;
            Angle = angle;
        }
    }
}