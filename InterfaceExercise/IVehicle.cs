using System;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        int HowManyWheels { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }

        void Drive();

        void DriveDefault()
        {
            Console.WriteLine("Default drive method inside interface");
        }
        
    }
}