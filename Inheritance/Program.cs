using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.Makechicken();
            chef.Makespecialdish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.Makechicken();
            italianChef.makepasta();
            italianChef.Makespecialdish();

            indianchef india = new indianchef();
            india.Makechicken();
            
        }
        
    }
}
