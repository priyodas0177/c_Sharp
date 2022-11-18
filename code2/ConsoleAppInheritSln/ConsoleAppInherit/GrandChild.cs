using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherit
{
    internal class GrandChild : Child
    {
        internal GrandChild() //: this(34)//: base(9)
        {
            Console.WriteLine("GC-D");
        }

        internal override void MethodB()
        {
            Console.WriteLine("GrandChild MethodB");
        }
    }
}
