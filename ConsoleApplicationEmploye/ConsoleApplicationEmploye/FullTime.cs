using System;
namespace ConsoleApplicationEmploye
{
    public class FullTime:Employe
    {
        private int bonus;
        internal int Bonus {
            get { return this.bonus; }
            set { this.bonus = value; }
        }
        internal  void GrossIncome() {
            Console.WriteLine("GrossIncome:{0}",((salary * 12) + bonus * 2));
        }

        internal void TotalTask() {
            Console.WriteLine("GrossIncome:{0}",((salary *12)+bonus*2)*0.25);
        }

        internal override void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine("Bonus:{0}",this.bonus);
        }
        

        
    }
}

