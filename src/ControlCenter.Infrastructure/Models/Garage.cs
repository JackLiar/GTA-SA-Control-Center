namespace ControlCenter.Infrastructure.Models
{
    public class Garage
    {
        public long Angle;
        public int CarCode;
        public long Handling;
        public byte MajorColor;
        public byte MinorColor;
        public int Specials;
        public byte[] TuneArrByte;
        public int[] TuneArrInt;
        public float Xcoord;
        public float Ycoord;
        public float Zcoord;
    }

    public class FullGarage
    {
        public Garage[] ParkingSlots;
    }
}