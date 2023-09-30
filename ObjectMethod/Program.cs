using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student("Shohan", 1206, (float)3.79);
            Student s2 = new Student("Asif", 1205, (float)3.45);

            Console.WriteLine(S1.HasHonors());
            Console.WriteLine(s2.HasHonors());

        }
    }
}
