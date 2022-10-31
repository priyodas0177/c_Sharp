using System;

namespace Encapsulation {
    class Account {
        int accountBalance = 1000;//datati private hoye gese bcz int ar samne kono datatype nai.
        // kivabe ai value ta access korbo?
        // 1. seter/gater method call kore.

        public void SetBalance(int amount){
            if (amount < 0)
            {
                Console.WriteLine(" You cannot pass negative value ");

            }
            else {
                accountBalance = amount;
            }
            
        }
        public void GetBalance() {
            Console.WriteLine("Your account balance is : "+accountBalance);
        }
    }
    class program {
        public static void Main(string[] args)
        {
            int val;
            Console.WriteLine("Enter the value : ");
            val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My value is : "+val);

            Account a = new Account();
            a.SetBalance(val);
            a.GetBalance();
            Console.ReadLine();

        }

    }
}



