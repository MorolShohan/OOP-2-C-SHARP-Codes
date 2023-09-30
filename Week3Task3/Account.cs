using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Task3
{
    internal class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public string AccName
        { get { return accName; } set { accName = value; } }
        public string Acid
        { get { return acid; } set { acid = value; } }

        /*internal void Withdraw()
        {
            throw new NotImplementedException();
        }

        internal void Deposit()
        {
            throw new NotImplementedException();
        }*/

        public int Balance
        { get { return balance; } set { balance = value; } }

        int newBalance;

        public void Deposit(int amount)
        {
           newBalance = balance + amount;
            Console.WriteLine("After depositing 1200 your new balance " +newBalance);

            

        }

        public void Withdraw(int amount)
        {
          newBalance = balance - amount; 
            Console.WriteLine("After withdrawing 1500 remaining balance "+newBalance);
        }

        public void showinfo()
        {
            Console.WriteLine(accName);
            Console.WriteLine(acid);
            Console.WriteLine("Previous Balance " +balance);
        }

    }
}
