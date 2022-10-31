using System;

namespace Array {
    class program {
        static void Main(string[] args) {

            string[] cars = new string[4] { "TA", "BMW", "FORD", "LAMBO" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // anothey way to print array (foreach diye)

            foreach (string car in cars) {
                Console.WriteLine(car);
            }
            
            Console.ReadLine();
        }
    }
}

