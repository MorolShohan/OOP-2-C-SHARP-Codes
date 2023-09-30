using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<=20; i++)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i+" is Even");

                }

                else
                {
                    Console.WriteLine(i + " is Odd ");
                }
            }

        }
    }
}
