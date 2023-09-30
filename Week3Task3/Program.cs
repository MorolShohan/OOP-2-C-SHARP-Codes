using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine("Enter Account Name");
            account.AccName = Console.ReadLine();
            Console.WriteLine("Enter account ID");
            account.Acid = Console.ReadLine();
            Console.WriteLine("Enter your balance");
            account.Balance = System.Convert.ToInt32((Console.ReadLine()));

                
            // account.Balance = 12000;

            account.showinfo();
            account.Withdraw(1500);
            account.Deposit(1200);
            

        }
    }
}
