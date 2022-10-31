using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent();
            //Child c = new Child();
            //Child c1 = new Child(100);
            //Child c2 = new Child("xyz");
            //Parent p1 = new Parent("hello");

            //Parent p = new Parent();
            //Child c = new Child();
            //Parent p1 = new Child();
            //Console.WriteLine();
            //p.MethodA();
            //c.MethodA();
            //p.MethodB();
            //c.MethodB();
            //p1.MethodA();
            //p1.MethodB();
            //p1.MethodC();

            Parent pp = new GrandChild();
            //Child c = new GrandChild();
            //GrandChild gc = new GrandChild();
            pp.MethodB();
        }
    }
}
