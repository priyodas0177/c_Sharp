using System;

namespace User_input {
    class program {
        public static void Main(String[] args) {
            string name;
            int age;
            int cgpa;
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("My name is : " + name);

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My age is :" + age);

            Console.WriteLine("Enter your cgpa");
            cgpa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My cgpa is :" + cgpa);
        }
    }
}

