using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_Contact_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact("Anila", "876", 21, "01698765432", 'M');
            c1.ShowPersonInfo();
            Contact c2 = new Contact();
            c2.PersonName = "Tahmina";
            c2.PersonID = "567";
            c2.Age = 22;
            c2.MobileNumber = "01567890987";
            c2.Gender = 'F';
            c2.ShowPersonInfo();
        }
    }
}
