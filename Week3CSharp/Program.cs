using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Enter your name ");
            person.name = Console.ReadLine();

            Console.Write("Enter your age ");
            /*int age = Convert.ToInt32(Console.ReadLine());*/
            person.Age = 45;

            person.showinformation();
            

        }
    }
}
