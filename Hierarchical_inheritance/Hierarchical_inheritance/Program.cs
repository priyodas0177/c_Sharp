// Inheritance without user input...
using System;
namespace Inheritance
{
    class car
    {
        public string model;
        public string color;
        public int price;
        public float mileage;

        public void PrintCarInformation()
        {  // method banaisi
            Console.WriteLine("Model : " + model);
            Console.WriteLine("color : " + color);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Mileage : " + mileage);
        }

    }
    class Lambo : car
    {
        public int speed;
        public void PrintSpeed()
        {
            Console.WriteLine("Speed : " + speed);
        }
    }

    class BMW : car
    {
        string look;
        public void PrintLook()
        {
            Console.WriteLine("Look : " + look);
        }

        public static void Main(string[] args)
        {

            BMW mycar = new BMW();
            mycar.model = "Series 6";
            mycar.price = 500000;
            mycar.color = "Blue";
            mycar.mileage = 7.5f;  // f deyar karon holo ata float variable
            mycar.look = "aggressive";
            mycar.speed = 300;
            mycar.PrintCarInformation();
            mycar.PrintLook();
            mycar.PrintSpeed();
            Console.ReadLine();
        }
    }
}

