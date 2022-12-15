using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string Year { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public int HowManyWheels { get; set; }

        public string Logo { get; set; }

        public DateTime DateEstablished { get; set; }

        public SUV()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
