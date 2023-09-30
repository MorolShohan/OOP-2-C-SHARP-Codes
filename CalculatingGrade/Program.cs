using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks of physics");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of chemistry");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Biology");
            int Biology = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Math");
            int Math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Computer");
            int Computer = Convert.ToInt32(Console.ReadLine());

            float Percentage = (physics + chemistry + Biology + Math + Computer) / 5;
            Console.WriteLine("Your percentage is :"+Percentage);

                if (Percentage >= 90)
            {
                Console.WriteLine("A+");
            }

            else if (Percentage >= 85 && Percentage <= 89)
            {
                Console.WriteLine("A");
            }

            else if (Percentage >= 80 && Percentage <= 85)
            { Console.WriteLine("B+");
            }

            else if (Percentage >= 75 && Percentage <= 79)
            {
                Console.WriteLine("B");
            }
            else if (Percentage >= 50 && Percentage <= 75)
            {
                Console.WriteLine("C+");
            }
            else if (Percentage < 50)
            {
                Console.WriteLine("F");
            }
                else
            {
                Console.WriteLine("Invalid Number");
                    }

        }
    }
}
