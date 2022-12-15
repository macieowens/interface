﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int HowManyWheels { get; set; }
        public string Logo { get; set; }
        public DateTime DateEstablished { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }
    }
}
