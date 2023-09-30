using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Task4
{
    internal class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

        public void showCourseInfo()
        {
            Console.WriteLine(CourseName);
            Console.WriteLine(CourseCode);
            Console.WriteLine(CourseCredit);

        }
    }
}
