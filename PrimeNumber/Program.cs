using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 33, flag = 0;
            for (int i = 2; i < 10; i++)
            {
                if (num % i == 0)
                {
                   
                    flag ++;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(num + "is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
        }
    }

    }
