
using System;
namespace TollPlaza
{
    internal class Vehicle
    {
        private string vehicleName;
        private string vehicleNumber;//licence number
        private string date;
        //byte[] array = new byte[10000];

        internal string VehicleName
        {
            set { this.vehicleName = value; }
            get { return this.vehicleName; }
        }

        internal string VehicleNumber
        {
            set { this.vehicleNumber = value; }
            get { return this.vehicleNumber; }                                                   
        }

        internal string Date
        {
            set { this.date = value; }
            get { return this.date; }
        }


        internal Vehicle()
        {

        }
        internal Vehicle(string vehicleName, string vehicleNumber, string date)
        {
            this.vehicleName = vehicleName;
            this.vehicleName = vehicleNumber;
            this.date = date;
        }
        internal void userinput()
        {

            Console.WriteLine("VehicleName : ");
            this.vehicleName = Console.ReadLine();
            Console.WriteLine("Vehicle Number : ");
            this.vehicleNumber = Console.ReadLine();
            Console.WriteLine("Date : ");
            this.date = Console.ReadLine();

            Console.WriteLine("Vehicle Name is :" + vehicleName);
            Console.WriteLine("Vehicle Number is  :" + vehicleNumber);
            Console.WriteLine("Date:" + date);

        }
        //internal void printInfo() {
        //	Console.WriteLine("Vehicle Name is :"+ vehicleName);
        //          Console.WriteLine("Vehicle Number is  :"+ vehicleNumber);
        //          Console.WriteLine("Date:"+ date);

        //      }

    }
}



