using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number for Triangle: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Sceond Number Triangle: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter thired Number Triangle: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x == y && y == z && x == z)
            {
                Console.WriteLine("Equilater");
            }
            else if (x != y && y == z && x != z)
            {
                Console.WriteLine("isosceles");
            }
            else if (z != x && y == x && z != y)
            {
                Console.WriteLine("isosceles");
            }
            else if (x != y && x == z && y != z)
            {
                Console.WriteLine("isosceles");
            }
            else if (x != y && y != z && x != z)
            {
                Console.WriteLine("scanlene");
            }

            Console.ReadKey();
        }
    }
}
   
