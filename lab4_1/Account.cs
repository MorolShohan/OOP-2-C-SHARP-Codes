using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    internal class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account()
        {
            accName = "";
            acid = "";
            balance = 0;
        }

        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public string AccountHolderName
        {
            set
            {
                this.accName = value;
            }
            get
            {
                return this.accName;
            }
        }

        public string AccountID
        {
            set
            {
                this.acid = value;
            }
            get
            {
                return this.acid;
            }
        }

        public int AccBalance
        {
            set
            {
                this.balance = value;
            }
            get
            {
                return this.balance;
            }
        }

        public void deposit(int amount)
        {
            if (amount >= 0)
            {
                this.balance += amount;
            }
            else
            {
                Console.WriteLine("Amount cannot be zero");
            }
        }

        public void withdraw(int amount)
        {
            if (amount <= this.balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient amount to withdraw");
            }
        }

        public void Transfer(int amount, Account a)
        {
            if (this.balance > amount)
            {
                this.balance -= amount;
                a.balance += amount;
            }
            else if (amount == 0)
            {
                Console.WriteLine("Amount Cannot be Zero");
            }
            else
            {
                Console.WriteLine("Not Enough Funds Available to Transfer");
            }
        }

    }
}
