using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midmubarak
{
    internal class student
    {
        private string name;
        public int roll;
        public static string dept = "CSE";
        public float cgpa;

         student(string v)
        {
            Console.WriteLine("This is default constructor");
        }
          public student(string sname, int sroll, string sdept, float scgpa)
        {
            name = sname;
            roll = sroll;
            dept = sdept;
            cgpa = scgpa;
        }

        public void showinfo()
        {
            Console.WriteLine("Name is :" + name);
            Console.WriteLine("Roll is :" + roll);
            Console.WriteLine("Dept is :" + dept);
            Console.WriteLine("CGPA IS:" + cgpa);
        }


    }
}
