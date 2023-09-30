using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Console.Write("\nAccount Name:");
            a1.Accname = Console.ReadLine();
            Console.Write("Account Id:");
            a1.Acid = Console.ReadLine();
            Console.WriteLine("Account Balance:" + a1.Balance);

            a1.Deposit(3000);
            a1.Withdraw(1400);
        }
    }
}
   
