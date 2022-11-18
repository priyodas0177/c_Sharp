// single Inheritance with user input...
using System;
namespace Inheritance
{
    class car
    {
        public string model;
        public string color;
        public int price;
        public double mileage;

        public void PrintCarInformation()
        {  // method banaisi
            Console.WriteLine("Enter Model name : ");
            model = Console.ReadLine();
            Console.WriteLine("Enter car color : ");
            color = Console.ReadLine();
            Console.WriteLine("Enter car Price : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter car Mileage : ");
            mileage = Convert.ToDouble(Console.ReadLine());

            
        }

    }

    class BMW : car
    {
        string look;
        public void PrintLook()
        {
            Console.WriteLine("Look : " );
            look = Console.ReadLine();
            Console.WriteLine(" Model name : " + model);
            Console.WriteLine("Colour : " + color);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Mileage : " + mileage);
            Console.WriteLine("Looks : "+look);
        }

        public static void Main(string[] args)
        {

            BMW mycar = new BMW();
           
            mycar.PrintCarInformation();
            mycar.PrintLook();
            Console.ReadLine();
        }
    }
}



