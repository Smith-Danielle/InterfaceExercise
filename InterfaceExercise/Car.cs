using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public int TrunkSpace { get; set; } //In cubic feet
        public bool HasSunroof { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Passengers { get; set; }
        public int Wheels { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
