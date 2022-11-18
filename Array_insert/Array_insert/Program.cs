using System;
namespace Array_insert {
    class program {
        public static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 20, 50, 70, 90 };
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }

            int a = 2;
            Console.WriteLine("value " + arr[a]);
            Console.WriteLine("value 2: " + arr[3]);
            a = 50;
            //changing array value at a certain index..
            arr[2] = 120;
            Console.WriteLine("new value : " + arr[2]);
            // inserting array value at a certain index..
           // arr[5] = 2000;
           // Console.WriteLine("array 5th value : " + arr[5]);
            // aivabe hobe na

            int[] b_arr = new int[7];


            Console.WriteLine("array_length "+b_arr.Length);
            for (int i = 0; i <b_arr.Length; i++) {
                Console.WriteLine(b_arr[i]);
            }

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Enter value for index : "+i);
                int x = Convert.ToInt32(Console.ReadLine());
                b_arr[i]=x;
            }
            for (int i = 0; i < b_arr.Length; i++) {
                Console.WriteLine(b_arr[i]);
            }
            b_arr[5] = 70;
            b_arr[6] = 80;
            for (int i = 0; i < b_arr.Length; i++) {
                Console.WriteLine(b_arr[i]);
            }

           
      

        }

        
                                       
    }
}

