using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcponentMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getpow(3, 2));
        }

        static int getpow(int basenum, int pownum)
        {
            int result = 1;

            for(int i = 0; i<pownum; i++)
            {
                result *= basenum;
            }

            return result;
        }
    }
}
