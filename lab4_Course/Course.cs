using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Course
{
    internal class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course()
        {
            courseName = "";
            courseCode = "";
            courseCredit = 0;
        }

        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public string Cname
        {
            set
            {
                this.courseName = value;
            }
            get
            {
                return this.courseName;
            }
        }
        public string Ccode
        {
            set
            {
                this.courseCode = value;
            }
            get
            {
                return this.courseCode;
            }
        }
        public int ccredit
        {
            set
            {
                this.courseCredit = value;
            }
            get
            {
                return this.courseCredit;
            }
        }


        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Code:{0}", this.courseCode);
            Console.WriteLine("Course Name:{0}", this.courseName);
            Console.WriteLine("Credit(s):{0}", this.courseCredit);

        }
    }
}
  