using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Passengers { get; set; }
        public int Wheels { get; set; }
    }
   
}
