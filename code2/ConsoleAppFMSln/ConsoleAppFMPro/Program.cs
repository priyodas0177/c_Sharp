using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFMPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            //c.Addition(3, 9, 7);
            //c.Addition("4", 8, 9);
            //c.Addition(9, "2");
            //c.Addition();
            //c.Addition("1", "2", 7);

            int[] a1 = new int[5] { 3, 5, 8, 2, 5 };
            int[] a2 = new int[4] { 3, 3, 82, 2 };
            //c.Addition(a1);

            Sample s = new Sample();
            //s.Summation(4, 3, 6, 8, 9, 2, 4, 7);
            //s.Summation(34, 6, 8, 1);
            //s.Summation(21, 4, 7, 331);
            //s.Summation(3, 6);
            //s.Summation();
            //s.Summation(23, 6, 8, 9, 8);
            //s.Summation(a2);

            int p = 10, q = 20, r;
            s.Swap(ref p, ref q);
            Console.WriteLine("After Swap p:{0},q:{1}", p, q);
            s.M1(out r);
            s.M2(10, 20);
            s.M3(c:5, a:6, b:7);
        }
    }
}
