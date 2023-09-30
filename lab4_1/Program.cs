using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account p1 = new Account("Anika", "124", 55000);
            Account p2 = new Account("Tashrif", "674", 75000);
            Account p3 = new Account("Anila", "987", 84000);
            Account p4 = new Account();
            p4.AccountHolderName = "Raya";
            p4.AccountID = "876";
            p4.AccBalance = 65000;
            Account p5 = new Account();
            p5.AccountHolderName = "Orpa";
            p5.AccountID = "512";
            p5.AccBalance = 95000;
            Console.WriteLine("Accounts\n");
            Console.WriteLine("Initial Account 1");
            Console.WriteLine("Account Creation Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p1.AccountHolderName, p1.AccountID, p1.AccBalance);
            Console.WriteLine("Initial Account 2");
            Console.WriteLine("Account Creation Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p2.AccountHolderName, p2.AccountID, p2.AccBalance);
            Console.WriteLine("Initial Account 3");
            Console.WriteLine("Account Creation Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p3.AccountHolderName, p3.AccountID, p3.AccBalance);
            Console.WriteLine("Initial Account 4");
            Console.WriteLine("Account Creation Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p4.AccountHolderName, p4.AccountID, p4.AccBalance);
            Console.WriteLine("Initial Account 5");
            Console.WriteLine("Account Creation Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p5.AccountHolderName, p5.AccountID, p5.AccBalance);
            Console.WriteLine("Transactions\n");
            Console.WriteLine("Transferring 20000 from Account 1 to Account 2\n");
            p1.Transfer(19500, p2);
            Console.WriteLine("After Transaction Account 1");
            Console.WriteLine("Transaction Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p1.AccountHolderName, p1.AccountID, p1.AccBalance);
            Console.WriteLine("After Transaction Account 2");
            Console.WriteLine("Transaction Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p2.AccountHolderName, p2.AccountID, p2.AccBalance);
            Console.WriteLine("Transferring 10000 from Account 4 to Account 3\n");
            p4.Transfer(15000, p3);
            Console.WriteLine("After Transaction Account 3");
            Console.WriteLine("Transaction Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p3.AccountHolderName, p3.AccountID, p3.AccBalance);
            Console.WriteLine("After Transaction Account 4");
            Console.WriteLine("Transaction Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p4.AccountHolderName, p4.AccountID, p4.AccBalance);
            Console.WriteLine("Depositiong 15000 in Account 5\n");
            p5.deposit(20000);
            Console.WriteLine("After Transaction Account 5");
            Console.WriteLine("Transaction Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p5.AccountHolderName, p5.AccountID, p5.AccBalance);
            Console.WriteLine("Withdrawing 5000 from Account 5\n");
            p5.withdraw(7000);
            Console.WriteLine("After Transaction Account 5");
            Console.WriteLine("Transaction Time and Date: {0}", DateTime.Now);
            Console.WriteLine("Account Holder Name: {0}\nAccount Number : {1}\nInitial Balance : {2}\n", p5.AccountHolderName, p5.AccountID, p5.AccBalance);

        }
    }
}


