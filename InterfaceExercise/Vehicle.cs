using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise;

public class Vehicle : IVehicle
{
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string HasTrunk { get; set; }

    public void Drive()
    {
        Console.WriteLine($"Driving in my{GetType().Name}"); 
    } 
}