using System;
namespace Array {
    class array_found {
        public static void Main(String[] args) {
            int[] array_no = { 20,50,60,70,100};
            bool found = false;

            for (int i = 0; i < array_no.Length; i++) {
                if (array_no[i] == 25)
                {
                    Console.WriteLine("We founded!");
                    found = true;
                    break;
                }
                

            }
            if(!found)
            {
                Console.WriteLine("Not founded!");
            }
        }
    }
}


