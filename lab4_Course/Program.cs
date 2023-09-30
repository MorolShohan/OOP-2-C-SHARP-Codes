using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.Cname = "Discrete Mathematics";
            c1.Ccode = "CSC1204";
            c1.ccredit = 3;
            c1.ShowCourseInfo();
            Console.WriteLine();
            Course c2 = new Course();
            c2.Cname = "Algorithms";
            c2.Ccode = "CSC2211";
            c2.ccredit = 3;
            c2.ShowCourseInfo();
            Console.WriteLine();
            Course c3 = new Course("Data Structure", "CSC2107", 3);
            c3.ShowCourseInfo();
        }

    }
}
        
