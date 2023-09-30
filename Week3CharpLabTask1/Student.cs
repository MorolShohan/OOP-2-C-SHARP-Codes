using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CharpLabTask1
{
    internal class Student
    {
        private string name;
        private string id;
        private string dept;
        private float cgpa;

        public string Name
        { get { return name; } set { name = value; } }
        public string Id
        { get { return id; } set { id = value; } }
        public float Cgpa
        { get { return cgpa; } set => cgpa = value; }
        public string Dept
        { get { return dept; } set { dept = value; } }

        public void showinfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);  
            Console.WriteLine(dept);
            Console.WriteLine(cgpa);
        }



    }
}
