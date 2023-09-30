using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Mobile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mobile m1 = new Mobile("Anika", "01678987654", "199", "ios", false);
            m1.ShowInfo();
            Console.WriteLine();
            m1.Recharge(50);
            Console.WriteLine();
            Console.WriteLine("After Recharge");
            m1.ShowInfo();
            m1.CallSomeone(15);
            Console.WriteLine("\nAfter a Call");
            Console.WriteLine();
            m1.ShowInfo();
        }
    }
    }
