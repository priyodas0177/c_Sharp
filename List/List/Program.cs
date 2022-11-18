using System;

namespace list {
    class program {
        static void Main(String[] args) {

            List<string> cars = new List<string>();
            cars.Add("TATA");
            cars.Add("BMW");
            cars.Add("FORD");
            cars.Add("LAMBO");
            for (int i = 0; i < cars.Count; i++) {
                Console.WriteLine(cars[i]);
            }
            Console.ReadLine();
        }

    }
}



