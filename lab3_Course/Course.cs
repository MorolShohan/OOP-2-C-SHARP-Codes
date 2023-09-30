using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Course
{
    internal class Course
    {

        private string courseName;
        private string courseCode;
        private int courseCredit;
        void SetInfo(string cname, string ccode, int ccredit)
        {
            courseName = cname;
            courseCode = ccode;
            courseCredit = ccredit;
        }
        string getCourseName()
        {
            return courseName;
        }
        string getcoursCode()
        {
            return courseCode;
        }
        int getcourseCredit()
        {
            return courseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine(courseName + " " + courseCode + " " + courseCredit);
        }
    }
}
