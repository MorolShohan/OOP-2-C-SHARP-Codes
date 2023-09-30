using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CharpLabTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "shohan";
            student.Id = "20-44038-2";
            student.Dept = "CSE";
            student.Cgpa = 3.79f;

            student.showinfo();
            

        }
    }
}
