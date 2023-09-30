using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoorLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] symbol = { 4, 8, 6, 2, 8, 52, 3, 4, 8, 6, 44 };
            for (int i = 0; i< symbol.Length; i++)
            {
                Console.WriteLine(symbol[i]);
            }
        }
    }
}
