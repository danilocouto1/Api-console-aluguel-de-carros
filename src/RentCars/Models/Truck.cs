using RentCars.Types;

namespace RentCars.Models
{
    public class Truck : Vehicle
    {
        public int Seats { get; set; }
        public int Doors { get; set; }
        public double LoadCapacity;
        public BrakeType BrakeType { get; set; }
    }
}
