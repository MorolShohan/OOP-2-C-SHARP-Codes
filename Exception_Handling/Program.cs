using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number :");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The ans is = " + num1 / num2);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            
        }
    }
}
