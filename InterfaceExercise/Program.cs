using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region InferfaceRegion

            Car myFirstCar = new Car { HowManyWheels = 4, Year = "2021", Make = "Complicated", Model = "Crazy" };
            SUV mySUV = new SUV { Model = "SUV", Make = "Big", Year = "2003", HowManyWheels = 4 };
            Truck myTruck = new Truck { Model = "Loud", HowManyWheels = 4, Make = "Pink", Year = "2014"};

            List<IVehicle> myList = new List<IVehicle>();

            foreach (IVehicle vehicle in myList)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model} HasWheels: {vehicle.HowManyWheels}");
                Console.WriteLine();
                vehicle.Drive();
                vehicle.DriveDefault();
                Console.WriteLine();
            }



            #endregion

            Console.WriteLine();

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
