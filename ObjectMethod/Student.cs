using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethod
{
     class Student
    {
        string name;
        int roll;
        float gpa;

       

        public Student(string sname, int sroll, float sgpa)
        {
            this.name = sname;
            this.roll = sroll;
            this.gpa = sgpa;

        }

        public bool HasHonors()
        { if(gpa>= 3.5)
            { return true; }
        return false;
                }

    }
}
