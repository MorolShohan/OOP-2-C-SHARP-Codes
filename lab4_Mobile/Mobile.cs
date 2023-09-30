using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Mobile
{
    internal class Mobile
    {
        private string mobileOwnerName;
        private string mobileNumber;
        private string mobileBalance;
        private string mobileOSName;
        private bool locked;

        public Mobile()
        {
            mobileOwnerName = "";
            mobileNumber = "";
            mobileBalance = "";
            mobileOSName = "";
            locked = false;
        }

        public Mobile(string mobileOwnerName, string mobileNumber, string mobileBalance, string mobileOSName, bool locked)
        {
            this.mobileOwnerName = mobileOwnerName;
            this.mobileNumber = mobileNumber;
            this.mobileBalance = mobileBalance;
            this.mobileOSName = mobileOSName;
            this.locked = locked;
        }

        public string MobileOwnerName
        {
            set
            {
                this.mobileOwnerName = value;
            }
            get
            {
                return this.mobileOwnerName;
            }
        }

        public string MobileNumber
        {
            set
            {
                this.mobileNumber = value;
            }
            get
            {
                return this.mobileNumber;
            }
        }

        public string MobileBalance
        {
            set
            {
                this.mobileBalance = value;
            }
            get
            {
                return this.mobileBalance;
            }
        }

        public string MobileOSName
        {
            set
            {
                this.mobileOSName = value;
            }
            get
            {
                return this.mobileOSName;
            }
        }

        public bool LockStatus
        {
            set
            {
                this.locked = value;
            }
            get
            {
                return this.locked;
            }
        }

        public void Recharge(int amount)
        {
            int balance = int.Parse(this.mobileBalance);
            Console.WriteLine("Unlock Phone?");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'y' || c == 'Y')
            {
                locked = false;
            }
            else
            {
                locked = true;
            }

            if (amount > 0 && locked == false)
            {
                balance += amount;
                this.mobileBalance = balance.ToString();
                Console.WriteLine("{0} Taka Recharged Successfully", amount);
            }
            else if (amount < 0)
            {
                Console.WriteLine("Amount cannot be zero");
            }
            else if (locked == true)
            {
                Console.WriteLine("Unlock the Phone First");
            }
        }

        public void CallSomeone(int timeDuration)
        {
            Console.WriteLine("\nCalling Someone");
            Console.WriteLine("Unlock Phone?");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'y' || c == 'Y')
            {
                locked = false;
            }
            else
            {
                locked = true;
            }

            if (!locked)
            {
                int perminutecost = 1;
                int totalAmountCosted = perminutecost * timeDuration;
                int balance = int.Parse(this.mobileBalance);
                balance -= totalAmountCosted;
                this.mobileBalance = balance.ToString();
                Console.WriteLine("After {0} minute call your current balance is {1}", timeDuration, this.mobileBalance);
            }
            else
                Console.WriteLine("Unlock the Phone First");
        }

        public void ShowInfo()
        {

            if (!locked)
            {
                Console.WriteLine("Mobile Owner : {0}", this.mobileOwnerName);
                Console.WriteLine("Number : {0}", this.mobileNumber);
                Console.WriteLine("Balance : {0}", this.mobileBalance);
                Console.WriteLine("Lock Status : {0}", this.locked);
            }
            else
            {
                Console.WriteLine("Unlock the Phone First!");
            }
        }

    }

}

