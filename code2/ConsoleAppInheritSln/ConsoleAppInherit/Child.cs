using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherit
{
    internal class Child : Parent
    {
        internal Child() //: this(34)//: base(9)
        {
            Console.WriteLine("C-D");
        }

        internal Child(int r) : base("world")//: base(r)
        {
            Console.WriteLine("C-NDI " + r);
        }

        internal Child(string l) : this()//: base(12)
        {
            Console.WriteLine("C-NDS " + l);
        }

        internal void MethodA()
        {
            Console.WriteLine("Child MethodA");
        }

        internal override void MethodB()
        {
            Console.WriteLine("Child MethodB");
        }

        internal new void MethodC()
        {
            Console.WriteLine("Child MethodC");
        }
    }
}
