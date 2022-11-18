using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherit
{
    internal class Parent
    {
        internal Parent() //: this(129)
        {
            Console.WriteLine("P-D");
        }

        internal Parent(int u)
        {
            Console.WriteLine("P-NDI " + u);
        }

        internal Parent(string u) : this()
        {
            Console.WriteLine("P-NDS " + u);
        }

        internal void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("Parent MethodB");
        }

        internal virtual void MethodC()
        {
            Console.WriteLine("Parent MethodB");
        }
    }
}
