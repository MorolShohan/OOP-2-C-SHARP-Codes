

using System;

namespace CSharpTutorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            SayHi("Shohan", 33);
            */
            Console.WriteLine(cube(5));

        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}