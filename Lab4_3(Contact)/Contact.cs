using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_Contact_
{
    internal class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;

        public Contact()
        {
            personName = "";
            personId = "";
            age = 0;
            mobileNumber = "";
            gender = '\0';
        }

        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string PersonName
        {
            set
            {
                this.personName = value;
            }
            get
            {
                return this.personName;
            }
        }

        public string PersonID
        {
            set
            {
                this.personId = value;
            }
            get
            {
                return this.personId;
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

        public char Gender
        {
            set
            {
                this.gender = value;
            }
            get
            {
                return this.gender;
            }
        }

        public void DetectMobileOperator()
        {
            if (this.mobileNumber.Substring(0, 3).Equals("017"))
            {
                Console.WriteLine("Your Operator is GrameenPhone");
            }
            else if (this.mobileNumber.Substring(0, 3).Equals("013"))
            {
                Console.WriteLine("Your Operator is GrameenPhone");
            }

            else if (this.mobileNumber.Substring(0, 3).Equals("019"))
            {
                Console.WriteLine("Your Operator is Banglalink");
            }
            else if (this.mobileNumber.Substring(0, 3).Equals("016"))
            {
                Console.WriteLine("Your Operator is Airtel");
            }
            else if (this.mobileNumber.Substring(0, 3).Equals("018"))
            {
                Console.WriteLine("Your Operator is Robi");
            }
            else if (this.mobileNumber.Substring(0, 3).Equals("015"))
            {
                Console.WriteLine("Your Operator is Teletalk");
            }

            else
            {
                Console.WriteLine("No Such Operator Available");
            }
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine("Name : {0}\nID : {1}\nAge : {2}\nMobile Number : {3}\nGender : {4}", this.personName, this.personId, this.age, this.mobileNumber, this.gender);
            DetectMobileOperator();
            Console.WriteLine();
        }

    }
}

