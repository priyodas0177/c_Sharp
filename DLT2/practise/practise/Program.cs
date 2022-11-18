using System;
using Final;

namespace Final
{
    internal class Child
    {
        public Child()
        {

            Console.WriteLine("Child");
        }

        public Child(int i)
        {
            Console.WriteLine("Dhaka " +i);
        } 
        public Child(string j, int k) : this(k)
        {
            Console.WriteLine("Khulna " + j);
        }
        public virtual void print()
        {
            Console.WriteLine("In child class");
        }


    }
}

internal class Prarent : Child
{
    public Prarent(int x)
    {
        Console.WriteLine("Sylhet" + x);
    }
    public Prarent(int x, string y)
    {
        Console.WriteLine("Barishal " + x);
    }
    public Prarent(string y)
    {
        Console.WriteLine("Bogura" + y);
    }
    public override void print()
    {
        Console.WriteLine("In parent class");
    }

}

internal class program
{
    public static void Main(string[] args)
    {
        Child x = new Child();
        Child y = new Child(15);
        Prarent z = new Prarent(10);
        Prarent j = new Prarent("priyo");

        z.print();
        y.print();
        x.print();
    }
}

//Child
//Dhaka 15
//Child
//sylhet 10
//Child
//Bogura priyo
//In parent class
//In child class
//In child class