using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.CourseName = "C#";
            course.CourseCredit = 3;
            course.CourseCode = "CS-1223";

            course.showCourseInfo();
        }
    }
}
