using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            int count=1;

            byte[] array= new byte[2]; 
             
            foreach (byte a in array) {
                Console.WriteLine("Person "+count);
                Console.WriteLine("Enter your name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your Address ");
                address = Console.ReadLine();
                Console.WriteLine("My name is: "+name);
                Console.WriteLine("My address is: "+address);
                // Console.ReadLine();

               
                count ++;



                // Console.WriteLine(a);
            }
           
            Console.ReadLine();
            


        }
    }
}
