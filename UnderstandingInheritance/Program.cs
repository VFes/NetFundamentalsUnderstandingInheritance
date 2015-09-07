using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "White";
            myTruck.TowingCapacity = 1200;

            printVehicleDetails(myTruck);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle´s details: {0}",
            vehicle.FormatMe());
        }
    }

    abstract class Vehicle //is the abstract base/parent/super class
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();
    }// Ends class Vehicle

    class Car : Vehicle //Creating a Drive/Child/Sub  class that inherits from Vehicle
    {
        

        //Creating a helper method
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Color);
        }
    }//Ends class Car
     
     //Sealed means that no class will inherit from this class, the equivalent to final for classes in java
     sealed class Truck : Vehicle // Drive/Child/Sub Class (Inherits from) base/parent/super Class name
    {
        public int TowingCapacity { get; set; }

        //Creating an overrided helper method
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} Towing units",
                this.Make,
                this.Model,
                this.Year,
                this.Color,
                this.TowingCapacity);
        }

    }//Ends Class Truck
}
