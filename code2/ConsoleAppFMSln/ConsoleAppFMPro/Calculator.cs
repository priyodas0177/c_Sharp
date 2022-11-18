using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFMPro
{
    internal class Calculator
    {
        internal void Addition(int x, int y)
        {
            Console.WriteLine("{0}", x + y);
        }

        internal void Addition(int x, int y, int z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        internal void Addition(int x, int y, int z, int h)
        {
            Console.WriteLine("{0}", x + y);
        }

        internal void Addition(string x, int r)
        {
            Console.WriteLine("{0}", x + r);
        }

        internal void Addition(int x, string r)
        {
            Console.WriteLine("{0}", x + r);
        }

        internal void Addition(int x, string y, int z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        internal void Addition(string x, int y, int z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        internal void Addition(string x, string y, int z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        internal void Addition(string x, int y, string z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        internal int Addition()
        {
            Console.WriteLine("6");
            return 4;
        }

        internal int Addition(int[] arr)
        {
            int sum = 0, count = 0;
            while (count < arr.Length)
            {
                sum += arr[count];
                count++;
            }
            Console.WriteLine("{0}", sum);
            return sum;
        }
    }
}
