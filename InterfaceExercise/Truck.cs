using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public int HowManyWheels { get; set; }

        public string Logo { get; set; }

        public DateTime DateEstablished { get; set; }


        public Truck()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
