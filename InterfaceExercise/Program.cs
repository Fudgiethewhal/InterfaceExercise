﻿using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            Car myFirstCar = new Car { Year = "1992", Make = "Toyota", Model = "Corolla", HasTrunk = true};
            Truck myFirstTruck = new Truck { Year = "2001", Make = "Ford", Model = "F-150", HasTailgate = true};
            SUV myFirstSUV = new SUV { Year = "2002", Make = "Nissan", Model = "Rouge", OpenTrunk = true };
            
            List<IVehicle> vehicles = new List<IVehicle>();
            
            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstTruck);
            vehicles.Add(myFirstSUV);

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.Drive();
                vehicle.DriveDefault();
                Console.WriteLine();
            }

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            Console.ReadLine();
        }
    }
}
