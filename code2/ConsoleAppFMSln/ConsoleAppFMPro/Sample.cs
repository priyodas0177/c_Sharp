using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFMPro
{
    internal class Sample
    {
        internal int Summation(params int[] arr)
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

        internal void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
            Console.WriteLine("After Swap a:{0},b:{1}", a, b);
        }

        internal void M1(out int h)
        {
            h = 8;
        }

        internal void M2(byte p, byte q = 2, byte r = 3)
        { 
        }

        internal void M3(int a, int b, int c)
        { 
        }

        internal void M4(int a, string b, Calculator c, double[] r, ref byte t, out bool z, decimal[] u, params long[] j)
        {
            z = false;
        }
    }
}
