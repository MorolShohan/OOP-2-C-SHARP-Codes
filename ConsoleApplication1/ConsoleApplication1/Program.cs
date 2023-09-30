using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(num1 + num2);
        }
    }
}