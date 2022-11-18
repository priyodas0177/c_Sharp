using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        protected byte id;
        protected string name;
        protected string rank;
        protected byte salary;
        protected string joiningDate;

        internal byte Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal string Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }
        internal string Joining_Date
        {
            get { return this.joiningDate; }
            set { this.joiningDate = value; }
        }
        internal byte Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        //internal Employe(byte id;string name;string JoiningDate;string rank) {

        //    }

        internal Employee()
        {

        }
        internal Employee(byte id, string name, string rank, string joiningDate, byte salary)
        {
            this.id = id;
            this.name = name;
            this.rank = rank;
            this.joiningDate = joiningDate;
            this.salary = salary;
        }
        internal virtual void ShowInfo()
        {
            Console.WriteLine("Id:{0}", this.id);
            Console.WriteLine("Name:{0}", this.name);
            Console.WriteLine("Rank:{0}", this.rank);
            Console.WriteLine("Joining_date:{0}", this.Joining_Date);
            Console.WriteLine("Salary:{0}", this.salary);




        }

    }
}

    

