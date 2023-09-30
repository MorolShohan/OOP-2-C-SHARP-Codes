using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midmubarak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("SHOHAN", 20440382,"CSE", (float)3.57);
            student s2 = new student("Masum", 20438853, "CSE", (float)3.43);

            s1.showinfo();
        }
    }
}
