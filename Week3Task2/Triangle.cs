using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Task2
{
    internal class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z   
        {
            get { return z; }
            set { z = value; }
        }

       
        public void TestTiangle()
        {
            if (x == y && y == z)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (x == y || x == z || y == z)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }
        }

        internal void showinfo()
        {
            throw new NotImplementedException();
        }
    }
}
