using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public bool HasCamper { get; set; }
        public int FlatbedSpace { get; set; } //In cubic feet

        public string Make { get; set; }
        public string Model { get; set; }
        public int Passengers { get; set; }
        public int Wheels { get; set; }


        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
