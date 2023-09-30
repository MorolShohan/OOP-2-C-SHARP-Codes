using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetInfo("Nazifa", "20-43016-1", "CSE", 3.65f);
            Console.WriteLine("Student Name : " + s.getName());
            Console.WriteLine("Student ID : " + s.getId());
            Console.WriteLine("Student Department : " + s.getDepartment());
            Console.WriteLine("Student CGPA : " + s.getCgpa());
            Console.ReadKey();
        }
    }
    }
}
