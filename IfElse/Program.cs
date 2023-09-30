using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool istall = false;

            if(isMale && istall)
            {
                Console.WriteLine("YOU ARE Tall MALE");
            }
            else if (isMale && !istall)
            {
                Console.WriteLine("YOU ARE a short MALE");
            }
            else if (!isMale && istall)
            {
                Console.WriteLine("you are not a male but you are tall");

            }

            else
            {
                Console.WriteLine("you are nothing");
            }
        }
    }
}
