using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CSharp
{
    internal class Person
    {
        public string name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void showinformation()
        {
            Console.WriteLine("Name: " + name + "Age: " + age);
        }
    }
}
