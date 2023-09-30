using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Student
{
    internal class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;
        void SetInfo(string sname, string sid, string sdepartment, float scgpa)
        {
            name = sname;
            id = sid;
            department = sdepartment;
            cgpa = scgpa;
        }
        string getName()
        {
            return name;
        }
        string getId()
        {
            return id;
        }
        string getDepartment()
        {
            return department;
        }
        float getCgpa()
        {
            return cgpa;
        }
    }
}
