using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Account
{
    internal class Account
    {
        private string accName;
        private string accid;
        private int balance;
        public string Accname
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Acid
        {
            get { return Acid; }
            set { Acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("\n" + amount + " Tk deposited to the account");
            Console.WriteLine("Current Balance: " + balance);
        }

        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("\n" + amount + " Tk withdrawed from the account");
            Console.WriteLine("Current Balance: " + balance);
        }

        public void showInfo()
        {
            Console.WriteLine("\nAccount Name: " + accName);
            Console.WriteLine("Account Id: " + Acid);
            Console.WriteLine("Account balance: " + balance);



        }
    }
}
