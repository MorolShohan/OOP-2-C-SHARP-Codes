using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef : Chef

    {
        public ItalianChef()
        {

        }


        public override void Makespecialdish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }

        public void makepasta()
        {
            Console.WriteLine("CAN MAKE PASTA");
        }

        public virtual void makeitalianspecialdish()
        {
            Console.WriteLine("can make italian dish");
        }
    }
}


