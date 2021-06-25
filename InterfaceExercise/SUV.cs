using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public bool HasThreeRows { get; set; }
        public int BackSeatsPerRow { get; set; } 

        public string Make { get; set; }
        public string Model { get; set; }
        public int Passengers { get; set; }
        public int Wheels { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
