// See https://aka.ms/new-console-template for more information



namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            string phonenumber;
            int count = 1;

            byte[] array = new byte[3];

            foreach (byte a in array)
            {
                Console.WriteLine("dELETE ");
                Console.WriteLine("Delete 2 ");

                Console.WriteLine("Person " + count);
                Console.WriteLine("Enter your name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your Address ");
                address = Console.ReadLine();
                Console.WriteLine("Enter your PhoneNumber ");
                phonenumber = Console.ReadLine();

                Console.WriteLine("My name is: " + name);
                Console.WriteLine("My address is: " + address);
                Console.WriteLine("My phoneNumber is: " + phonenumber);

                // Console.ReadLine();


                count++;



                // Console.WriteLine(a);
            }

            Console.ReadLine();



        }
    }
}


