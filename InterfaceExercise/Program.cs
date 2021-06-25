using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - Complete

            //Create 3 classes called Car , Truck , & SUV - Complete

            //In your IVehicle - Complete

            /* Create 4 members that Car, Truck, & SUV all have in common. -
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany - Complete

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes -Complete

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values; - Complete
            //Creatively display and organize their values

            List<IVehicle> vAspects = new List<IVehicle>();
            List<ICompany> cAspects = new List<ICompany>();
            List<Car> carSpecs = new List<Car>();
            List<Truck> truckSpecs = new List<Truck>();
            List<SUV> suvSpecs = new List<SUV>();

            Car car1 = new Car() { Make = "Ford", Model = "Taurus", Passengers = 5, Wheels = 4, Logo = "Red Roof", Name = "Pizza Hut", TrunkSpace = 20, HasSunroof = false };
            vAspects.Add(car1);
            cAspects.Add(car1);
            carSpecs.Add(car1);

            Truck truck1 = new Truck() { Make = "Chevrolet", Model = "Silverado", Passengers = 3, Wheels = 4, Logo = "House", Name = "Lowes", HasCamper = false, FlatbedSpace = 60 };
            vAspects.Add(truck1);
            cAspects.Add(truck1);
            truckSpecs.Add(truck1);

            SUV suv1 = new SUV() { Make = "GMC", Model = "Yukon", Passengers = 8, Wheels = 4, Logo = "Eagle", Name = "US Governemnt", HasThreeRows = true, BackSeatsPerRow = 3 };
            vAspects.Add(suv1);
            cAspects.Add(suv1);
            suvSpecs.Add(suv1);

            Console.WriteLine("Lets gather some records on each car.");
            Console.WriteLine("First, lets check out the basic specs:");
            int count = 1;
            foreach (var item in vAspects)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Car: {count}");
                Console.WriteLine($"{item.Make}");
                Console.WriteLine($"{item.Model}");
                Console.WriteLine($"Passenger Capacity: {item.Passengers}");
                Console.WriteLine($"Wheel Count: {item.Wheels}");
                count++;

            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Now, lets check out the purchasers and thier decals:");
            int count2 = 1;
            foreach (var item in cAspects)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"Car: {count2}");
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"{item.Logo}");
                count2++;

            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("However, we can also printout all the specs for each vehicle with their custom details.");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine($"For the Car type. ");
            Console.WriteLine("----------------------------------------------------");
            foreach (var item in carSpecs)
            {
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Number of Wheels: {item.Wheels}");
                Console.WriteLine($"Passenger Capacity: {item.Passengers}");
                Console.WriteLine($"Purchased by: {item.Name}");
                Console.WriteLine($"Decal: {item.Logo}");
                Console.WriteLine($"Sunroof: {item.HasSunroof}");
                Console.WriteLine($"Truck Space in Cubic Feet: {item.TrunkSpace}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"For the Truck type. ");
            Console.WriteLine("----------------------------------------------------");
            foreach (var item in truckSpecs)
            {
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Number of Wheels: {item.Wheels}");
                Console.WriteLine($"Passenger Capacity: {item.Passengers}");
                Console.WriteLine($"Purchased by: {item.Name}");
                Console.WriteLine($"Decal: {item.Logo}");
                Console.WriteLine($"Flatbed Space in Cubic Feet: {item.FlatbedSpace}");
                Console.WriteLine($"Camper: {item.HasCamper}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"For the SUV type. ");
            Console.WriteLine("----------------------------------------------------");
            foreach (var item in suvSpecs)
            {
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Number of Wheels: {item.Wheels}");
                Console.WriteLine($"Passenger Capacity: {item.Passengers}");
                Console.WriteLine($"Purchased by: {item.Name}");
                Console.WriteLine($"Decal: {item.Logo}");
                Console.WriteLine($"Seats per Row (back): {item.BackSeatsPerRow}");
                Console.WriteLine($"Three Rows: {item.HasThreeRows}");

            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("---------------End of Directory---------------------");

        }
    }
}
